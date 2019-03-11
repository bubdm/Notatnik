using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik.Obiekty
{
    class Zastap
    {


        public void ZastapFraze(RichTextBox richTextBox, MenuStrip menuStrip)
        {
            Szukaj szukaj = new Szukaj();

            if (string.IsNullOrWhiteSpace(menuStrip.Items[1].Text) || string.IsNullOrWhiteSpace(menuStrip.Items[3].Text))
            {
                MessageBox.Show("Nie wypełnione pola fraz.", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (szukaj.SzukajFrazy(richTextBox, menuStrip.Items[1].Text))
                {

                    richTextBox.Text = richTextBox.Text.Replace(menuStrip.Items[1].Text, menuStrip.Items[3].Text);
                    MessageBox.Show("Fraza została zastąpiona pomyślnie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Nie znaleliono takiej frazy w tekscie", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
