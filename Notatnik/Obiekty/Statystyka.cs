using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik.Obiekty
{
    class Statystyka
    {
        public string Statystyki(RichTextBox richTextBox ,string sciezka)
        {
            string tresc = "Statystyki \n\n" +
           "Wymiary okna tekstowego:\t " + richTextBox.Size + "\n" +
           "Aktualna liczba znaków:\t " + richTextBox.TextLength + "\n" +
            "Maksymalna liczba znaków:\t " + richTextBox.MaxLength + "\n"
            + "Kolor zanków:\t\t " + richTextBox.ForeColor + "\n" +
            "Ilosc lini:\t\t\t " + richTextBox.Lines.Length + "\n" +
           "Rodzaj czcionki:\t" + richTextBox.SelectionFont + "\n";
            if (sciezka == "")
            {
                tresc += "Sciezka do pliku :\t Brak \n";
                tresc += "Rozszerzenie pliku:\t Brak \n";
            }
            else
            {
                tresc += "Sciezka do pliku:\t" + sciezka + "\n";
                string[] rozszerzenie = sciezka.Split('.');
                tresc += "Rozszerzeniepliku:\t" + rozszerzenie[1] + "\n";
            }

            return tresc;
        }
    }
}
