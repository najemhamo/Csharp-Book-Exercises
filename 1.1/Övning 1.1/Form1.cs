using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Omvandla till int
            int tal1 = ParseToInt(tbx_tal1.Text);
            int tal2 = ParseToInt(tbx_tal2.Text);

            // Omvandla summan till sträng och visa svaret
            int sum = tal1 + tal2;

            lbl_resultat.Text = ChangeToString(sum);

        }

        private int ParseToInt(string text)
        {

            int tal = 0;
            // Variabeln bestämmer om talet är negativ eller positiv
            int värde = 1;

            // Börja med värdet an entalet
            int positionsVärde = 1;


            // Parse texten och beräkna tal
            for(int i = text.Length -1; i >= 0; i--)
            {
                // Om första tecknet är '-' ändras värde till -1
                if (i == 0 && text[i].Equals('-'))
                {
                    värde = -1;
                }
                else
                {

                    int teckenVärde = text[i] - 48;


                    if (teckenVärde >= 0 && 9 >= teckenVärde)
                    {
                        tal += teckenVärde * positionsVärde;
                        positionsVärde *= 10;
                    }else
                    {
                        // Om tecknet är inget siffra så blir det fel
                        throw new InvalidCastException();
                    }
                }
            }
            // Talet multipliceras med värde
            return tal * värde;
        }

        private string ChangeToString(int nummer)
        {
            string text = "";
            int positionsVärde = 1;

            if(nummer < 0)
            {
                text = "-";
                nummer *= -1;
            }

            // PositionsVärde på talet räknas
            while (true)
            {
                int div = nummer / positionsVärde;
                if(div == 0)
                {
                    positionsVärde /= 10;
                    break;
                }else
                {
                    positionsVärde *= 10;
                }
            }

            // Den fyller strängen med tecken
            while ( positionsVärde > 0)
            {
                int nummer2 = nummer / positionsVärde;
                char tecken = Convert.ToChar(48 + nummer2);
                text = text + tecken;

                nummer = nummer - (nummer2 * positionsVärde);
                positionsVärde /= 10;
            }

            return text;
        }
    }
}
