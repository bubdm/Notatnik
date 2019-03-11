using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik.Obiekty
{
    class Czcionka
    {

        public bool CzcionkaZmien(RichTextBox richtext, FontDialog dialog)
        {
            bool wynik = false;
            dialog.Font = richtext.SelectionFont;
            dialog.Color = richtext.SelectionColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richtext.SelectionFont = dialog.Font;
                richtext.SelectionColor = dialog.Color;
                wynik = true;
            }
            return wynik;
        }
    }
}
