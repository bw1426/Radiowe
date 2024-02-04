using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiowe
{
    internal class Dzielenie0:Exception
    {
        public  Dzielenie0(Label wynik)
        {
            wynik.Text = "Nie dziel przez 0";
        }

     
    }
}
