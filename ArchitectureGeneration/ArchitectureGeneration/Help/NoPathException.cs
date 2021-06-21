using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureGeneration.Help
{
    public class NoPathException : Exception
    {
        public NoPathException(string message) : base(message)
        {
        }
    }
}