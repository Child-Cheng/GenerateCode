using ArchitectureGeneration.Help;
using ICSharpCode.TextEditor.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ArchitectureGeneration
{
    public partial class PreviewCode : Form
    {
        public PreviewCode()
        {
            InitializeComponent();
        }

        private string _code;

        public PreviewCode(string code)
        {
            InitializeComponent();
            _code = code;
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            textEditorControl.Encoding = System.Text.Encoding.UTF8;
            textEditorControl.Font = new Font("Hack", 12);
            //自定义代码高亮
            string path = Path.Combine(AppPath.GetPath(), "HighLighting");//指向自定义的文件
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(path))
            {
                fsmp = new FileSyntaxModeProvider(path);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                textEditorControl.SetHighlighting("C#");
            }
            textEditorControl.Text = _code;
        }
    }
}