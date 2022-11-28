using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lr_07
{
    public class GenericException : Exception
    {
        public string Error { get; set; }
        public GenericException(string message, string value)
            : base(message)
        {
            this.Error = value;
        }
    }
    
}
