
using ICSharpCode.TextEditor.Document;
using System.Windows.Forms;

namespace ArchitectureGeneration
{
    partial class PreviewCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 1238);
            this.textEditorControl = new ICSharpCode.TextEditor.TextEditorControl();
            textEditorControl.Dock = DockStyle.Fill;
            textEditorControl.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            textEditorControl.Encoding = System.Text.Encoding.Default;
            textEditorControl.Load += TextEditor_Load;
            this.Controls.Add(textEditorControl);
            this.Name = "Preview";
            this.Text = "Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl textEditorControl;
    }
}