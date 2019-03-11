using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik.Obiekty
{
    public class Szukaj
    {
        public bool SzukajFrazy( RichTextBox richTextBox, string szukany)
        {
            bool returnValue = false;
            if (richTextBox.Text.Length > 0)
            {
                int indexToText = richTextBox.Find(szukany);

                if (indexToText >= 0)
                {
                    returnValue = true;
                }
            }
            return returnValue;
        }

        public List<int> SzukajFraz(RichTextBox richTextBox , string szukany)
        {
            List<int> look = new List<int>();
            int start = 0;

            string text = szukany;
            int indexToText = -1;
            if (text.Length > 0)
            {
                do
                {
                    indexToText = richTextBox.Find(text, start, richTextBox.TextLength, RichTextBoxFinds.MatchCase);
                    if (indexToText >= 0)
                    {
                        start = indexToText;
                        start++;
                        look.Add(indexToText);
                    }
                } while (indexToText != -1 && start != richTextBox.TextLength);
            }
            return look;

        }
    }
}
