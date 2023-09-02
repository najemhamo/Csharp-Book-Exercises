namespace Övning_6._2
{
    partial class Form1
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
            this.tabsRegistrering = new System.Windows.Forms.TabControl();
            this.tpg_elever = new System.Windows.Forms.TabPage();
            this.btn_elev = new System.Windows.Forms.Button();
            this.tbx_efternamn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_förnamn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_personNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpg_kurser = new System.Windows.Forms.TabPage();
            this.btn_kurs = new System.Windows.Forms.Button();
            this.tbx_poäng = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_kursnamn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_kusrkod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpg_böcker = new System.Windows.Forms.TabPage();
            this.btn_bok = new System.Windows.Forms.Button();
            this.tbx_ämne = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_titel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tpg_boklån = new System.Windows.Forms.TabPage();
            this.tbx_bokNrLån = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_lån = new System.Windows.Forms.Button();
            this.tbx_datum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_personNrBöcker = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpg_kursval = new System.Windows.Forms.TabPage();
            this.btn_kursval = new System.Windows.Forms.Button();
            this.tbx_kurskodVal = new System.Windows.Forms.TextBox();
            this.Kurskod = new System.Windows.Forms.Label();
            this.tbx_personNrVal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlHöger = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dataVy = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlVisa = new System.Windows.Forms.Panel();
            this.tbx_data = new System.Windows.Forms.TextBox();
            this.cmdVisaMeny = new System.Windows.Forms.ComboBox();
            this.btn_uppdate = new System.Windows.Forms.Button();
            this.tabsRegistrering.SuspendLayout();
            this.tpg_elever.SuspendLayout();
            this.tpg_kurser.SuspendLayout();
            this.tpg_böcker.SuspendLayout();
            this.tpg_boklån.SuspendLayout();
            this.tpg_kursval.SuspendLayout();
            this.pnlHöger.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVy)).BeginInit();
            this.pnlVisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsRegistrering
            // 
            this.tabsRegistrering.Controls.Add(this.tpg_elever);
            this.tabsRegistrering.Controls.Add(this.tpg_kurser);
            this.tabsRegistrering.Controls.Add(this.tpg_böcker);
            this.tabsRegistrering.Controls.Add(this.tpg_boklån);
            this.tabsRegistrering.Controls.Add(this.tpg_kursval);
            this.tabsRegistrering.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabsRegistrering.Location = new System.Drawing.Point(0, 0);
            this.tabsRegistrering.Name = "tabsRegistrering";
            this.tabsRegistrering.SelectedIndex = 0;
            this.tabsRegistrering.Size = new System.Drawing.Size(250, 441);
            this.tabsRegistrering.TabIndex = 0;
            // 
            // tpg_elever
            // 
            this.tpg_elever.Controls.Add(this.btn_elev);
            this.tpg_elever.Controls.Add(this.tbx_efternamn);
            this.tpg_elever.Controls.Add(this.label3);
            this.tpg_elever.Controls.Add(this.tbx_förnamn);
            this.tpg_elever.Controls.Add(this.label2);
            this.tpg_elever.Controls.Add(this.tbx_personNr);
            this.tpg_elever.Controls.Add(this.label1);
            this.tpg_elever.Location = new System.Drawing.Point(4, 22);
            this.tpg_elever.Name = "tpg_elever";
            this.tpg_elever.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_elever.Size = new System.Drawing.Size(242, 415);
            this.tpg_elever.TabIndex = 0;
            this.tpg_elever.Text = "Elever";
            this.tpg_elever.UseVisualStyleBackColor = true;
            // 
            // btn_elev
            // 
            this.btn_elev.Location = new System.Drawing.Point(114, 179);
            this.btn_elev.Name = "btn_elev";
            this.btn_elev.Size = new System.Drawing.Size(100, 23);
            this.btn_elev.TabIndex = 6;
            this.btn_elev.Text = "Registera elev";
            this.btn_elev.UseVisualStyleBackColor = true;
            this.btn_elev.Click += new System.EventHandler(this.btn_elev_Click);
            // 
            // tbx_efternamn
            // 
            this.tbx_efternamn.Location = new System.Drawing.Point(114, 134);
            this.tbx_efternamn.Name = "tbx_efternamn";
            this.tbx_efternamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_efternamn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Efternamn";
            // 
            // tbx_förnamn
            // 
            this.tbx_förnamn.Location = new System.Drawing.Point(114, 85);
            this.tbx_förnamn.Name = "tbx_förnamn";
            this.tbx_förnamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_förnamn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Förnamn";
            // 
            // tbx_personNr
            // 
            this.tbx_personNr.Location = new System.Drawing.Point(114, 35);
            this.tbx_personNr.Name = "tbx_personNr";
            this.tbx_personNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_personNr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personnummer";
            // 
            // tpg_kurser
            // 
            this.tpg_kurser.Controls.Add(this.btn_kurs);
            this.tpg_kurser.Controls.Add(this.tbx_poäng);
            this.tpg_kurser.Controls.Add(this.label4);
            this.tpg_kurser.Controls.Add(this.tbx_kursnamn);
            this.tpg_kurser.Controls.Add(this.label5);
            this.tpg_kurser.Controls.Add(this.tbx_kusrkod);
            this.tpg_kurser.Controls.Add(this.label6);
            this.tpg_kurser.Location = new System.Drawing.Point(4, 22);
            this.tpg_kurser.Name = "tpg_kurser";
            this.tpg_kurser.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_kurser.Size = new System.Drawing.Size(242, 415);
            this.tpg_kurser.TabIndex = 1;
            this.tpg_kurser.Text = "Kurser";
            this.tpg_kurser.UseVisualStyleBackColor = true;
            // 
            // btn_kurs
            // 
            this.btn_kurs.Location = new System.Drawing.Point(110, 182);
            this.btn_kurs.Name = "btn_kurs";
            this.btn_kurs.Size = new System.Drawing.Size(100, 23);
            this.btn_kurs.TabIndex = 13;
            this.btn_kurs.Text = "Registera kurs";
            this.btn_kurs.UseVisualStyleBackColor = true;
            this.btn_kurs.Click += new System.EventHandler(this.btn_kurs_Click);
            // 
            // tbx_poäng
            // 
            this.tbx_poäng.Location = new System.Drawing.Point(110, 137);
            this.tbx_poäng.Name = "tbx_poäng";
            this.tbx_poäng.Size = new System.Drawing.Size(100, 20);
            this.tbx_poäng.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Poäng";
            // 
            // tbx_kursnamn
            // 
            this.tbx_kursnamn.Location = new System.Drawing.Point(110, 88);
            this.tbx_kursnamn.Name = "tbx_kursnamn";
            this.tbx_kursnamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_kursnamn.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kursnamn";
            // 
            // tbx_kusrkod
            // 
            this.tbx_kusrkod.Location = new System.Drawing.Point(110, 38);
            this.tbx_kusrkod.Name = "tbx_kusrkod";
            this.tbx_kusrkod.Size = new System.Drawing.Size(100, 20);
            this.tbx_kusrkod.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kurskod";
            // 
            // tpg_böcker
            // 
            this.tpg_böcker.Controls.Add(this.btn_bok);
            this.tpg_böcker.Controls.Add(this.tbx_ämne);
            this.tpg_böcker.Controls.Add(this.label8);
            this.tpg_böcker.Controls.Add(this.tbx_titel);
            this.tpg_böcker.Controls.Add(this.label9);
            this.tpg_böcker.Location = new System.Drawing.Point(4, 22);
            this.tpg_böcker.Name = "tpg_böcker";
            this.tpg_böcker.Size = new System.Drawing.Size(242, 415);
            this.tpg_böcker.TabIndex = 2;
            this.tpg_böcker.Text = "Böcker";
            this.tpg_böcker.UseVisualStyleBackColor = true;
            // 
            // btn_bok
            // 
            this.btn_bok.Location = new System.Drawing.Point(111, 134);
            this.btn_bok.Name = "btn_bok";
            this.btn_bok.Size = new System.Drawing.Size(100, 23);
            this.btn_bok.TabIndex = 20;
            this.btn_bok.Text = "Registera bok";
            this.btn_bok.UseVisualStyleBackColor = true;
            this.btn_bok.Click += new System.EventHandler(this.btn_bok_Click);
            // 
            // tbx_ämne
            // 
            this.tbx_ämne.Location = new System.Drawing.Point(111, 79);
            this.tbx_ämne.Name = "tbx_ämne";
            this.tbx_ämne.Size = new System.Drawing.Size(100, 20);
            this.tbx_ämne.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ämne";
            // 
            // tbx_titel
            // 
            this.tbx_titel.Location = new System.Drawing.Point(111, 29);
            this.tbx_titel.Name = "tbx_titel";
            this.tbx_titel.Size = new System.Drawing.Size(100, 20);
            this.tbx_titel.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Titel";
            // 
            // tpg_boklån
            // 
            this.tpg_boklån.Controls.Add(this.tbx_bokNrLån);
            this.tpg_boklån.Controls.Add(this.label11);
            this.tpg_boklån.Controls.Add(this.btn_lån);
            this.tpg_boklån.Controls.Add(this.tbx_datum);
            this.tpg_boklån.Controls.Add(this.label10);
            this.tpg_boklån.Controls.Add(this.tbx_personNrBöcker);
            this.tpg_boklån.Controls.Add(this.label7);
            this.tpg_boklån.Location = new System.Drawing.Point(4, 22);
            this.tpg_boklån.Name = "tpg_boklån";
            this.tpg_boklån.Size = new System.Drawing.Size(242, 415);
            this.tpg_boklån.TabIndex = 3;
            this.tpg_boklån.Text = "Boklån";
            this.tpg_boklån.UseVisualStyleBackColor = true;
            // 
            // tbx_bokNrLån
            // 
            this.tbx_bokNrLån.Location = new System.Drawing.Point(115, 144);
            this.tbx_bokNrLån.Name = "tbx_bokNrLån";
            this.tbx_bokNrLån.Size = new System.Drawing.Size(100, 20);
            this.tbx_bokNrLån.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Boknummer";
            // 
            // btn_lån
            // 
            this.btn_lån.Location = new System.Drawing.Point(115, 190);
            this.btn_lån.Name = "btn_lån";
            this.btn_lån.Size = new System.Drawing.Size(100, 23);
            this.btn_lån.TabIndex = 27;
            this.btn_lån.Text = "Registera lån";
            this.btn_lån.UseVisualStyleBackColor = true;
            this.btn_lån.Click += new System.EventHandler(this.btn_lån_Click);
            // 
            // tbx_datum
            // 
            this.tbx_datum.Location = new System.Drawing.Point(115, 102);
            this.tbx_datum.Name = "tbx_datum";
            this.tbx_datum.Size = new System.Drawing.Size(100, 20);
            this.tbx_datum.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Lånedatum";
            // 
            // tbx_personNrBöcker
            // 
            this.tbx_personNrBöcker.Location = new System.Drawing.Point(115, 58);
            this.tbx_personNrBöcker.Name = "tbx_personNrBöcker";
            this.tbx_personNrBöcker.Size = new System.Drawing.Size(100, 20);
            this.tbx_personNrBöcker.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Personnummer";
            // 
            // tpg_kursval
            // 
            this.tpg_kursval.Controls.Add(this.btn_kursval);
            this.tpg_kursval.Controls.Add(this.tbx_kurskodVal);
            this.tpg_kursval.Controls.Add(this.Kurskod);
            this.tpg_kursval.Controls.Add(this.tbx_personNrVal);
            this.tpg_kursval.Controls.Add(this.label12);
            this.tpg_kursval.Location = new System.Drawing.Point(4, 22);
            this.tpg_kursval.Name = "tpg_kursval";
            this.tpg_kursval.Size = new System.Drawing.Size(242, 415);
            this.tpg_kursval.TabIndex = 4;
            this.tpg_kursval.Text = "Kursval";
            this.tpg_kursval.UseVisualStyleBackColor = true;
            // 
            // btn_kursval
            // 
            this.btn_kursval.Location = new System.Drawing.Point(114, 157);
            this.btn_kursval.Name = "btn_kursval";
            this.btn_kursval.Size = new System.Drawing.Size(100, 23);
            this.btn_kursval.TabIndex = 32;
            this.btn_kursval.Text = "Registera kursval";
            this.btn_kursval.UseVisualStyleBackColor = true;
            this.btn_kursval.Click += new System.EventHandler(this.btn_kursval_Click);
            // 
            // tbx_kurskodVal
            // 
            this.tbx_kurskodVal.Location = new System.Drawing.Point(114, 93);
            this.tbx_kurskodVal.Name = "tbx_kurskodVal";
            this.tbx_kurskodVal.Size = new System.Drawing.Size(100, 20);
            this.tbx_kurskodVal.TabIndex = 31;
            // 
            // Kurskod
            // 
            this.Kurskod.AutoSize = true;
            this.Kurskod.Location = new System.Drawing.Point(21, 96);
            this.Kurskod.Name = "Kurskod";
            this.Kurskod.Size = new System.Drawing.Size(46, 13);
            this.Kurskod.TabIndex = 30;
            this.Kurskod.Text = "Kurskod";
            // 
            // tbx_personNrVal
            // 
            this.tbx_personNrVal.Location = new System.Drawing.Point(114, 45);
            this.tbx_personNrVal.Name = "tbx_personNrVal";
            this.tbx_personNrVal.Size = new System.Drawing.Size(100, 20);
            this.tbx_personNrVal.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Personnummer";
            // 
            // pnlHöger
            // 
            this.pnlHöger.Controls.Add(this.pnlData);
            this.pnlHöger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHöger.Location = new System.Drawing.Point(250, 0);
            this.pnlHöger.Name = "pnlHöger";
            this.pnlHöger.Size = new System.Drawing.Size(374, 441);
            this.pnlHöger.TabIndex = 1;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dataVy);
            this.pnlData.Controls.Add(this.pnlVisa);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(374, 441);
            this.pnlData.TabIndex = 0;
            // 
            // dataVy
            // 
            this.dataVy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.dataVy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataVy.Location = new System.Drawing.Point(0, 51);
            this.dataVy.Name = "dataVy";
            this.dataVy.Size = new System.Drawing.Size(374, 390);
            this.dataVy.TabIndex = 1;
            // 
            // col1
            // 
            this.col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1.HeaderText = "PersonNr";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col2.HeaderText = "Låndatum";
            this.col2.Name = "col2";
            this.col2.Visible = false;
            // 
            // col3
            // 
            this.col3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col3.HeaderText = "Förnamn";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col4.HeaderText = "Efternamn";
            this.col4.Name = "col4";
            // 
            // col5
            // 
            this.col5.HeaderText = "Column1";
            this.col5.Name = "col5";
            this.col5.Visible = false;
            // 
            // pnlVisa
            // 
            this.pnlVisa.Controls.Add(this.tbx_data);
            this.pnlVisa.Controls.Add(this.cmdVisaMeny);
            this.pnlVisa.Controls.Add(this.btn_uppdate);
            this.pnlVisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVisa.Location = new System.Drawing.Point(0, 0);
            this.pnlVisa.Name = "pnlVisa";
            this.pnlVisa.Size = new System.Drawing.Size(374, 51);
            this.pnlVisa.TabIndex = 0;
            // 
            // tbx_data
            // 
            this.tbx_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_data.Enabled = false;
            this.tbx_data.Location = new System.Drawing.Point(42, 20);
            this.tbx_data.Name = "tbx_data";
            this.tbx_data.Size = new System.Drawing.Size(100, 20);
            this.tbx_data.TabIndex = 2;
            // 
            // cmdVisaMeny
            // 
            this.cmdVisaMeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVisaMeny.FormattingEnabled = true;
            this.cmdVisaMeny.Items.AddRange(new object[] {
            "Visa alla elever",
            "Visa alla böcker",
            "Visa alla kurser",
            "Visa lediga böcker",
            "Visa lånade böcker",
            "Visa kursgrupp"});
            this.cmdVisaMeny.Location = new System.Drawing.Point(160, 20);
            this.cmdVisaMeny.Name = "cmdVisaMeny";
            this.cmdVisaMeny.Size = new System.Drawing.Size(121, 21);
            this.cmdVisaMeny.TabIndex = 1;
            this.cmdVisaMeny.SelectedIndexChanged += new System.EventHandler(this.cmdVisaMeny_SelectedIndexChanged);
            // 
            // btn_uppdate
            // 
            this.btn_uppdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_uppdate.Location = new System.Drawing.Point(287, 20);
            this.btn_uppdate.Name = "btn_uppdate";
            this.btn_uppdate.Size = new System.Drawing.Size(75, 23);
            this.btn_uppdate.TabIndex = 0;
            this.btn_uppdate.Text = "Updatera";
            this.btn_uppdate.UseVisualStyleBackColor = true;
            this.btn_uppdate.Click += new System.EventHandler(this.btn_uppdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pnlHöger);
            this.Controls.Add(this.tabsRegistrering);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6.2";
            this.tabsRegistrering.ResumeLayout(false);
            this.tpg_elever.ResumeLayout(false);
            this.tpg_elever.PerformLayout();
            this.tpg_kurser.ResumeLayout(false);
            this.tpg_kurser.PerformLayout();
            this.tpg_böcker.ResumeLayout(false);
            this.tpg_böcker.PerformLayout();
            this.tpg_boklån.ResumeLayout(false);
            this.tpg_boklån.PerformLayout();
            this.tpg_kursval.ResumeLayout(false);
            this.tpg_kursval.PerformLayout();
            this.pnlHöger.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVy)).EndInit();
            this.pnlVisa.ResumeLayout(false);
            this.pnlVisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsRegistrering;
        private System.Windows.Forms.TabPage tpg_kurser;
        private System.Windows.Forms.TabPage tpg_böcker;
        private System.Windows.Forms.TabPage tpg_boklån;
        private System.Windows.Forms.TabPage tpg_kursval;
        private System.Windows.Forms.Panel pnlHöger;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dataVy;
        private System.Windows.Forms.Panel pnlVisa;
        private System.Windows.Forms.TabPage tpg_elever;
        private System.Windows.Forms.Button btn_elev;
        private System.Windows.Forms.TextBox tbx_efternamn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_förnamn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_personNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_data;
        private System.Windows.Forms.ComboBox cmdVisaMeny;
        private System.Windows.Forms.Button btn_uppdate;
        private System.Windows.Forms.Button btn_kurs;
        private System.Windows.Forms.TextBox tbx_poäng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_kursnamn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_kusrkod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_bok;
        private System.Windows.Forms.TextBox tbx_ämne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_titel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_lån;
        private System.Windows.Forms.TextBox tbx_datum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_personNrBöcker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_kursval;
        private System.Windows.Forms.TextBox tbx_kurskodVal;
        private System.Windows.Forms.Label Kurskod;
        private System.Windows.Forms.TextBox tbx_personNrVal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.TextBox tbx_bokNrLån;
        private System.Windows.Forms.Label label11;
    }
}

