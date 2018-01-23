using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajaOngkir_FrontEnd.Model
{
    class Courier
    {
        private string code;
        private string name;

        public Courier(string code, string name)
        {
            this.code = code;
            this.name = name;
        }

        public string Code
        {
            get { return code; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
