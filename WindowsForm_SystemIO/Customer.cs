using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_SystemIO
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public string country { get; set; }

        public override string ToString()
        {
            return name + " " + surName;
        }

    }
}
