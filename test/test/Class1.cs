using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    public partial class Profile
    {
        public override int GetHashCode()
        {
            return 1456115;
        }

        public void Profile2(string password)
        {
            Console.WriteLine(GetHashCode());
        }
    }

}
