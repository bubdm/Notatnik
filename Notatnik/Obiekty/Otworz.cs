using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik.Obiekty
{
    class Otworz
    {
        public bool OtworzPlik(RichTextBox richTextBox , OpenFileDialog openDialog, ref string sciezka)
        {

          bool  wynik = false;
            DialogResult dialog = openDialog.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                try
                {
                    sciezka = openDialog.FileName;
                    richTextBox.LoadFile(sciezka);
                    richTextBox.Modified = false;
                    wynik = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można odczytać pliku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sciezka = "";
                }
              

            }
            return wynik;
        }
    }
}


