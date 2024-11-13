using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSystemConverter.Moldels
{
    public class Binary : Base
    {

        public Binary(string value) {

            value.TypeBaseCheck("01");
            this.Value = value; 

        }
        

    }
}
