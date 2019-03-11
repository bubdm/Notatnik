using System;
using System.Windows.Forms;

namespace Notatnik.Obiekty
{
    class Zapisz
    {
       public void ZapiszPlik(RichTextBox richTextBox, ref string nazwa)
        {
            if (nazwa != "")
            {
                try
                {                 
                    richTextBox.SaveFile(nazwa);
                    richTextBox.Modified = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd zapisu pliku " + nazwa, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nazwa = "";
                }
            }

        }
        public void ZapiszPlik(RichTextBox richTextBox, string nazwa)
        {
            if (nazwa != "")
            {
                try
                {
                    richTextBox.SaveFile(nazwa);
                    richTextBox.Modified = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd zapisu pliku " + nazwa, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nazwa = "";
                }
            }

        }
    }
}
