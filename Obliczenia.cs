using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiowe
{
    internal class Obliczenia
    {
        public static void   Licz(List<RadioButton> przyciskiRadiowe,Label wynik,TextBox l1, TextBox l2,Label dzialanie)
        {
            if (przyciskiRadiowe[0].Checked == true)
            {
                dzialanie.Text = przyciskiRadiowe[0].Text;
                wynik.Text = (Convert.ToDouble(l1.Text) + Convert.ToDouble(l2.Text)).ToString();
            }
            else if (przyciskiRadiowe[1].Checked == true)
            {
                dzialanie.Text = przyciskiRadiowe[1].Text;
                wynik.Text = (Convert.ToDouble(l1.Text) - Convert.ToDouble(l2.Text)).ToString();
            }

            else if (przyciskiRadiowe[2].Checked == true)
            {dzialanie.Text = przyciskiRadiowe[2].Text;
                wynik.Text = (Convert.ToDouble(l1.Text) * Convert.ToDouble(l2.Text)).ToString();
            }
            else if (przyciskiRadiowe[3].Checked == true)

            {
                dzialanie.Text = przyciskiRadiowe[3].Text;

                if (Convert.ToDouble(l2.Text)==0)
                {
                    throw new Dzielenie0(wynik);
                   // throw new DivideByZeroException();
                }

               wynik.Text = (Convert.ToDouble(l1.Text) / Convert.ToDouble(l2.Text)).ToString();
            }
        }
    }
}
