using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_05
{
    interface IFighters
    {
        void Actions();

    }

    public interface ICloneable
    {
        bool DoClone();
    }

}