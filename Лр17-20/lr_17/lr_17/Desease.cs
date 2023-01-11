using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_17
{
    public class Disease
    {
        public Nurse Nurse { get; set; }
        public Hospital Hospital { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Nurse != null)
                sb.Append(Nurse.Analis + "\n");
            if (Hospital != null)
                sb.Append("\r\nHuge cough  \n");
            return sb.ToString();
        }
    }
}
