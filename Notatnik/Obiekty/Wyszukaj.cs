using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik.Obiekty
{
    class Wyszukaj
    {
        static int kolejka;
   
        int[] znalezione = null;      
        public Wyszukaj()
        {
            kolejka = 0;
        }

        public string WyszukajFraze(RichTextBox richTextBox, string szukany)
        {
            string wynik = "";
         

            Szukaj szukaj = new Szukaj();
            znalezione = szukaj.SzukajFraz(richTextBox, szukany).ToArray();
            if (znalezione.Length > 0)
            {
                string txt = "Znaleziono : ";

                if (kolejka == 0)
                {
                    int z = szukany.Length;
                    int y = znalezione[0];
                    richTextBox.Select(y, z);

                    kolejka = 1;

                    txt += "1";
                }
                else
                {
                    txt = (kolejka + 1).ToString();

                    int z = szukany.Length;
                    int y = znalezione[kolejka];
                    richTextBox.Select(y, z);
                    kolejka++;
                    if (kolejka >= znalezione.Length)
                    {
                        kolejka = 0;
                    }

                }
                txt += "/" + znalezione.Length;
                wynik = txt;
                richTextBox.IsAccessible = true;
               
            }
            else
            {
                if (szukany.Length > 0)
                {
                    MessageBox.Show("Nie znaleziono takiej frazy.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Nie wypełnione pole frazy do wyszukania.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }




            }
            return wynik;
        }
    }
}
