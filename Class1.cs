using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNTest1
{
    class Class1
    {
        
        public string pubVar = "class-1 public variable";
        private string prVar;

        // Private Variables/fields/Atrtributes are not accessible to other class(Main Class - Data Encapsulation)
        //But can be made accessible to other classes by Property get & set methods

        public string PrVar
        {
            get { return prVar; }
            set { prVar = value; }
        }

    }
}
