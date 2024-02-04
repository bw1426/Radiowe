using System.Collections.Generic;
using System.DirectoryServices;
using System.Reflection.Metadata;
using System.Windows.Forms.VisualStyles;

namespace Radiowe
{
    public partial class Form1 : Form
    {
        GroupBox gbradiowe,gbdane;
         List<RadioButton> przyciskiRadiowe = new List<RadioButton>();
        TextBox l1, l2;
        Label wynik,rowne,dzialanie;
        int x = 0;
        
        public Form1()
        {
            InitializeComponent();
            gbradiowe= new GroupBox();
           // gbradiowe.AutoSize = true;
            gbradiowe.Width = 600;
            gbradiowe.Height= 100;
            Controls.Add(gbradiowe);
            
            this.Width=1600;
            this.Height = 800;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Text = "Kalkulator";
            this.BackColor= System.Drawing.Color.FromArgb(150,150,150);
           

            gbradiowe.Left =this.Width/2-gbradiowe.Width/2;
            gbradiowe.Top = this.Height / 2;
            
            for (int i=0;i<4;i++)
            {
                x = x + 120;
                przyciskiRadiowe.Add(new RadioButton());
                gbradiowe.Controls.Add(przyciskiRadiowe[i]);
                przyciskiRadiowe[i].Top = gbradiowe.Height / 2;
                przyciskiRadiowe[i].Left = x;
                przyciskiRadiowe[i].Font=new Font("", 30,FontStyle.Bold);
                przyciskiRadiowe[i].Size = new Size(60, 40);



            }
            przyciskiRadiowe[0].Text = "+";
            przyciskiRadiowe[1].Text = "-";
            przyciskiRadiowe[2].Text = "*";
            przyciskiRadiowe[3].Text = "/";

            gbdane=new GroupBox();
            Controls.Add(gbdane);
            gbdane.Width= this.Width -800;
            gbdane.Top = 100;
            gbdane.Left= this.Width/2-gbdane.Width/2;
            gbdane.AutoSize= true;
            l1 = new TextBox();
            l2 = new TextBox();
            wynik = new Label();
            rowne= new Label();
            dzialanie=new Label();

            
            gbdane.Controls.Add(l1);
            l1.Size = new System.Drawing.Size(150, 200);
            l1.TextAlign=HorizontalAlignment.Center;
           // l1.TextAlign =System.Windows.Forms.HorizontalAlignment.Center;
            l1.Font = new System.Drawing.Font("",40,FontStyle.Bold);
            l1.Location = new System.Drawing.Point(5, 40);
            gbdane.Controls.Add(dzialanie);
            gbdane.Controls.Add(l2);

            
            gbdane.Controls.Add(dzialanie);
            dzialanie.Size = new System.Drawing.Size(50, 200);
            dzialanie.AutoSize=true;
            
            dzialanie.Font = new System.Drawing.Font("", 40, FontStyle.Bold);
            dzialanie.Location = new System.Drawing.Point(160, 40);
           

            gbdane.Controls.Add(l2);



            l2.Size = new System.Drawing.Size(150, 200);
            l2.TextAlign = HorizontalAlignment.Center;

            
            l2.Font = new System.Drawing.Font("", 40, FontStyle.Bold);
            l2.Location = new System.Drawing.Point(220, 40);







            gbdane.Controls.Add(rowne);

            rowne.Size = new System.Drawing.Size(50, 200);
            
            rowne.Font = new System.Drawing.Font("", 40, FontStyle.Bold);
            rowne.Location = new System.Drawing.Point(390, 40);
            rowne.Text = "=";
            rowne.AutoSize= true;
            gbdane.Controls.Add(wynik);

            gbdane.Controls.Add(wynik);

            wynik.Size = new System.Drawing.Size(250, 200);

            wynik.Font = new System.Drawing.Font("", 40, FontStyle.Bold);
            wynik.Location = new System.Drawing.Point(440, 40);
           
           wynik.AutoSize= true;

            foreach (var item in przyciskiRadiowe)
            {
                item.Click += new EventHandler(Oblicz);

            }

            l1.Click += Czysc;
            l2.Click += Czysc;

        }

         void Oblicz(object? sender, EventArgs e)
        {
            try
            {
                Obliczenia.Licz(przyciskiRadiowe, wynik, l1, l2,dzialanie);

            }
            catch (DivideByZeroException ex)
            {
                wynik.Text="Nie dziel przez zero "+ex.Message;
            }
            catch (Dzielenie0)
            {

            }
            catch (FormatException ex)
            {
                wynik.Text = "Niew³aœciwy format danych " ;
            }
        

              catch (Exception ex)
            {
                wynik.Text = ex.Message;
            }


        }

        void Czysc(object? sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            //(sender as TextBox).Text = "";
           

        }
    }
}