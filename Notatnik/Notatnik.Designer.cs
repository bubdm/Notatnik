namespace Notatnik
{
    partial class Notatnik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopiujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.czcionkaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zastąpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.szukajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.zaznaczWszystkoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odznaczToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przywróćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.szukajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zastąpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odznaczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogolneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.tSMI_szukaj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_szukaj = new System.Windows.Forms.ToolStripTextBox();
            this.tSMI_znaleziono = new System.Windows.Forms.ToolStripMenuItem();
            this.closeszukajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tMSI_zastap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_faraza2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_faraza1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.closezastaptoolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "*.rtf|*.txt";
            this.saveDialog.Filter = "Tekst RTF|*.rtf| Plik tekstowy|*.txt";
            // 
            // openDialog
            // 
            this.openDialog.DefaultExt = "*.rtf|*.txt";
            this.openDialog.FileName = "openFileDialog1";
            this.openDialog.Filter = "Tekst RTF|*.rtf| Plik tekstowy|*.txt";
            // 
            // fontDialog
            // 
            this.fontDialog.ShowColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.contextMenuStrip;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.informacjaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopiujToolStripMenuItem1,
            this.wklejToolStripMenuItem1,
            this.wytnijToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.czcionkaToolStripMenuItem1,
            this.zastąpToolStripMenuItem1,
            this.szukajToolStripMenuItem1,
            this.toolStripMenuItem7,
            this.zaznaczWszystkoToolStripMenuItem1,
            this.odznaczToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(167, 192);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // kopiujToolStripMenuItem1
            // 
            this.kopiujToolStripMenuItem1.Name = "kopiujToolStripMenuItem1";
            this.kopiujToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.kopiujToolStripMenuItem1.Text = "Kopiuj";
            this.kopiujToolStripMenuItem1.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem1
            // 
            this.wklejToolStripMenuItem1.Name = "wklejToolStripMenuItem1";
            this.wklejToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.wklejToolStripMenuItem1.Text = "Wklej";
            this.wklejToolStripMenuItem1.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem1
            // 
            this.wytnijToolStripMenuItem1.Name = "wytnijToolStripMenuItem1";
            this.wytnijToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.wytnijToolStripMenuItem1.Text = "Wytnij";
            this.wytnijToolStripMenuItem1.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(163, 6);
            // 
            // czcionkaToolStripMenuItem1
            // 
            this.czcionkaToolStripMenuItem1.Name = "czcionkaToolStripMenuItem1";
            this.czcionkaToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.czcionkaToolStripMenuItem1.Text = "Czcionka";
            this.czcionkaToolStripMenuItem1.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // zastąpToolStripMenuItem1
            // 
            this.zastąpToolStripMenuItem1.Name = "zastąpToolStripMenuItem1";
            this.zastąpToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.zastąpToolStripMenuItem1.Text = "Zastąp";
            this.zastąpToolStripMenuItem1.Click += new System.EventHandler(this.zastąpToolStripMenuItem_Click);
            // 
            // szukajToolStripMenuItem1
            // 
            this.szukajToolStripMenuItem1.Name = "szukajToolStripMenuItem1";
            this.szukajToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.szukajToolStripMenuItem1.Text = "Szukaj";
            this.szukajToolStripMenuItem1.Click += new System.EventHandler(this.szukajToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(163, 6);
            // 
            // zaznaczWszystkoToolStripMenuItem1
            // 
            this.zaznaczWszystkoToolStripMenuItem1.Name = "zaznaczWszystkoToolStripMenuItem1";
            this.zaznaczWszystkoToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.zaznaczWszystkoToolStripMenuItem1.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem1.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // odznaczToolStripMenuItem1
            // 
            this.odznaczToolStripMenuItem1.Name = "odznaczToolStripMenuItem1";
            this.odznaczToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.odznaczToolStripMenuItem1.Text = "Odznacz";
            this.odznaczToolStripMenuItem1.Click += new System.EventHandler(this.odznaczToolStripMenuItem_Click);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.toolStripMenuItem4,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.DropDownOpening += new System.EventHandler(this.plikToolStripMenuItem_DropDownOpening);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(201, 6);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.przywróćToolStripMenuItem,
            this.toolStripMenuItem2,
            this.kopiujToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.toolStripMenuItem5,
            this.szukajToolStripMenuItem,
            this.zastąpToolStripMenuItem,
            this.czcionkaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.zaznaczWszystkoToolStripMenuItem,
            this.odznaczToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            this.edycjaToolStripMenuItem.DropDownOpening += new System.EventHandler(this.edycjaToolStripMenuItem_DropDownOpening);
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // przywróćToolStripMenuItem
            // 
            this.przywróćToolStripMenuItem.Name = "przywróćToolStripMenuItem";
            this.przywróćToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.przywróćToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.przywróćToolStripMenuItem.Text = "Przywróć";
            this.przywróćToolStripMenuItem.Click += new System.EventHandler(this.przywróćToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(205, 6);
            // 
            // szukajToolStripMenuItem
            // 
            this.szukajToolStripMenuItem.Name = "szukajToolStripMenuItem";
            this.szukajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.szukajToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.szukajToolStripMenuItem.Text = "Szukaj";
            this.szukajToolStripMenuItem.Click += new System.EventHandler(this.szukajToolStripMenuItem_Click);
            // 
            // zastąpToolStripMenuItem
            // 
            this.zastąpToolStripMenuItem.Name = "zastąpToolStripMenuItem";
            this.zastąpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.zastąpToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.zastąpToolStripMenuItem.Text = "Zastąp";
            this.zastąpToolStripMenuItem.Click += new System.EventHandler(this.zastąpToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(205, 6);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // odznaczToolStripMenuItem
            // 
            this.odznaczToolStripMenuItem.Name = "odznaczToolStripMenuItem";
            this.odznaczToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.odznaczToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.odznaczToolStripMenuItem.Text = "Odznacz";
            this.odznaczToolStripMenuItem.Click += new System.EventHandler(this.odznaczToolStripMenuItem_Click);
            // 
            // informacjaToolStripMenuItem
            // 
            this.informacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogolneToolStripMenuItem,
            this.statystykaToolStripMenuItem});
            this.informacjaToolStripMenuItem.Name = "informacjaToolStripMenuItem";
            this.informacjaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.informacjaToolStripMenuItem.Text = "Informacja";
            // 
            // ogolneToolStripMenuItem
            // 
            this.ogolneToolStripMenuItem.Name = "ogolneToolStripMenuItem";
            this.ogolneToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ogolneToolStripMenuItem.Text = "Ogólne";
            this.ogolneToolStripMenuItem.Click += new System.EventHandler(this.ogolneToolStripMenuItem_Click);
            // 
            // statystykaToolStripMenuItem
            // 
            this.statystykaToolStripMenuItem.Name = "statystykaToolStripMenuItem";
            this.statystykaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.statystykaToolStripMenuItem.Text = "Statystyka ";
            this.statystykaToolStripMenuItem.Click += new System.EventHandler(this.statystykaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox.Location = new System.Drawing.Point(2, 27);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 426);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // menuStrip3
            // 
            this.menuStrip3.AutoSize = false;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMI_szukaj,
            this.toolStripTextBox_szukaj,
            this.tSMI_znaleziono,
            this.closeszukajToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 426);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(804, 27);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // tSMI_szukaj
            // 
            this.tSMI_szukaj.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSMI_szukaj.Name = "tSMI_szukaj";
            this.tSMI_szukaj.Size = new System.Drawing.Size(52, 23);
            this.tSMI_szukaj.Text = "Szukaj";
            this.tSMI_szukaj.Click += new System.EventHandler(this.tSMI_szukaj_Click);
            // 
            // toolStripTextBox_szukaj
            // 
            this.toolStripTextBox_szukaj.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_szukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripTextBox_szukaj.Name = "toolStripTextBox_szukaj";
            this.toolStripTextBox_szukaj.Size = new System.Drawing.Size(200, 23);
            this.toolStripTextBox_szukaj.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tSMI_znaleziono
            // 
            this.tSMI_znaleziono.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSMI_znaleziono.Name = "tSMI_znaleziono";
            this.tSMI_znaleziono.Size = new System.Drawing.Size(12, 23);
            // 
            // closeszukajToolStripMenuItem
            // 
            this.closeszukajToolStripMenuItem.Name = "closeszukajToolStripMenuItem";
            this.closeszukajToolStripMenuItem.Size = new System.Drawing.Size(26, 23);
            this.closeszukajToolStripMenuItem.Text = "X";
            this.closeszukajToolStripMenuItem.Click += new System.EventHandler(this.closeszukajToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMSI_zastap,
            this.toolStripTextBox_faraza2,
            this.toolStripMenuItem11,
            this.toolStripTextBox_faraza1,
            this.toolStripMenuItem10,
            this.closezastaptoolStripMenuItem8});
            this.menuStrip2.Location = new System.Drawing.Point(0, 399);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(804, 27);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tMSI_zastap
            // 
            this.tMSI_zastap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tMSI_zastap.Name = "tMSI_zastap";
            this.tMSI_zastap.Size = new System.Drawing.Size(54, 23);
            this.tMSI_zastap.Text = "Zastąp";
            this.tMSI_zastap.Click += new System.EventHandler(this.tMSI_zastap_Click);
            // 
            // toolStripTextBox_faraza2
            // 
            this.toolStripTextBox_faraza2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_faraza2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripTextBox_faraza2.Name = "toolStripTextBox_faraza2";
            this.toolStripTextBox_faraza2.Size = new System.Drawing.Size(200, 23);
            this.toolStripTextBox_faraza2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(156, 23);
            this.toolStripMenuItem11.Text = "Wpisz fraze do zastąpienia";
            // 
            // toolStripTextBox_faraza1
            // 
            this.toolStripTextBox_faraza1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_faraza1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripTextBox_faraza1.Name = "toolStripTextBox_faraza1";
            this.toolStripTextBox_faraza1.Size = new System.Drawing.Size(200, 23);
            this.toolStripTextBox_faraza1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(110, 23);
            this.toolStripMenuItem10.Text = "Wpisz nową fraze";
            // 
            // closezastaptoolStripMenuItem8
            // 
            this.closezastaptoolStripMenuItem8.Name = "closezastaptoolStripMenuItem8";
            this.closezastaptoolStripMenuItem8.Size = new System.Drawing.Size(26, 23);
            this.closezastaptoolStripMenuItem8.Text = "X";
            this.closezastaptoolStripMenuItem8.Click += new System.EventHandler(this.closezastaptoolStripMenuItem8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 453);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(776, 156);
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przywróćToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem szukajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zastąpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odznaczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogolneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statystykaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem zastąpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem szukajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem odznaczToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem tSMI_szukaj;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_szukaj;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tSMI_znaleziono;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem closeszukajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMSI_zastap;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_faraza2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_faraza1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem closezastaptoolStripMenuItem8;
    }
}

