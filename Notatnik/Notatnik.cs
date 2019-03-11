using Notatnik.Obiekty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Notatnik : Form
    {
        #region Zmienne
        string sciezka = "";
        bool znacznik = false;
        Zapisz zapisz = new Zapisz();
   
        #endregion

        #region Konstruktor    
        public Notatnik()
        {
            InitializeComponent();
            Naglowek();
            Aktywnosc();
            menuStrip3.Height = 0;
            menuStrip2.Height = 0;


          

        }
        #endregion

        #region Metody
        public void Naglowek()
        {
            if (sciezka == "")
            {
                Text = "Notatnik";
            }
            else
            {
                Text = sciezka;
            }

            znacznik = richTextBox.Modified ? false : true;
            Znacznik(znacznik);
        }

        public void Znacznik(bool znacznik)
        {
            Text += znacznik ? "" : " *";
        }

        public void Aktywnosc()
        {
            cofnijToolStripMenuItem.Enabled = (richTextBox.CanUndo == false) ? false : true;
            przywróćToolStripMenuItem.Enabled = (richTextBox.CanRedo == false) ? false : true;
            kopiujToolStripMenuItem.Enabled = (richTextBox.SelectionLength > 0) ? true : false;
            kopiujToolStripMenuItem1.Enabled = (richTextBox.SelectionLength > 0) ? true : false;
            wytnijToolStripMenuItem1.Enabled = (richTextBox.SelectionLength > 0) ? true : false;
            wytnijToolStripMenuItem.Enabled = (richTextBox.SelectionLength > 0) ? true : false;
            odznaczToolStripMenuItem.Enabled = (richTextBox.SelectionLength > 0) ? true : false;
            odznaczToolStripMenuItem1.Enabled = (richTextBox.SelectionLength > 0) ? true : false;
            zapiszToolStripMenuItem.Enabled = (richTextBox.Modified == false) ? false : true;
        }

        bool Zamykanie()
        {
            bool wynik = false;
            if (richTextBox.Modified == true)
            {
                DialogResult dialog = MessageBox.Show("Czy zapisać zmiany?", "Uwaga", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (dialog)
                {
                    case DialogResult.Cancel:
                        wynik = true;
                        break;
                    case DialogResult.Yes:
                        zapiszToolStripMenuItem_Click(this, null);

                        break;
                    case DialogResult.No:

                        break;
                    default:
                        break;
                }


            }
            return wynik;
        }

            #endregion

        #region Zdarzenia

        #region Pomoc
            private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pomoc pomoc = new Pomoc();
        }
        #endregion

        #region Informacje
        private void ogolneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edytor tekstu Notatnik", "Informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void statystykaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statystyka statystyka = new Statystyka();

            MessageBox.Show(statystyka.Statystyki(richTextBox, sciezka), "Statystyki", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #endregion

        #region Edycja

        private void edycjaToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            Aktywnosc();
        }
        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanUndo == true) richTextBox.Undo();
        }

        private void przywróćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanRedo == true) richTextBox.Redo();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0) richTextBox.Copy();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0) richTextBox.Cut();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void szukajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip3.Height = 27;
        }

        private void zastąpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip2.Height = 27;
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Czcionka czcionka = new Czcionka();         
            if (czcionka.CzcionkaZmien(richTextBox, fontDialog))
            {
                Naglowek();
            }
          
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void odznaczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.DeselectAll();
        }
        #endregion

        #region Plik
        private void plikToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            Aktywnosc();
        }
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Zamykanie())
            {
                sciezka = "";
                richTextBox.Clear();
                richTextBox.Modified = false;
                Naglowek();
                Aktywnosc();
            }



        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Zamykanie())
            {
                Otworz otworz = new Otworz();
                if (otworz.OtworzPlik(richTextBox,openDialog,ref sciezka))
                {
                    Naglowek();
                    Aktywnosc();
                }
            }
         }
        

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sciezka == "")
            {
                zapiszJakoToolStripMenuItem_Click(sender, e);
            }
            else
            {
         
                zapisz.ZapiszPlik(richTextBox,ref sciezka);
                Naglowek();
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                zapisz.ZapiszPlik(richTextBox, saveDialog.FileName);
             
                Naglowek();
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

        #region Ogólne
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = Zamykanie();
        }
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            Naglowek();
        }
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Aktywnosc();
        }
        #endregion

        #region Szukaj
        private void tSMI_szukaj_Click(object sender, EventArgs e)
        {
            Wyszukaj wyszukaj = new Wyszukaj();
            wyszukaj.WyszukajFraze(richTextBox, toolStripTextBox_szukaj.Text);
        }

        private void closeszukajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip3.Height = 0;

        }
        #endregion

        #region Zastap

        private void tMSI_zastap_Click(object sender, EventArgs e)
        {
            Zastap zastap = new Zastap();
            zastap.ZastapFraze(richTextBox, menuStrip2);
            closezastaptoolStripMenuItem8_Click(sender, e);
        }



        private void closezastaptoolStripMenuItem8_Click(object sender, EventArgs e)
        {
            menuStrip2.Height = 0;
        }
        #endregion

        #endregion


    }
}
