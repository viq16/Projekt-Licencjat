namespace Football_Manager
{
    partial class OknoGlowne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoGlowne));
            this.bZatwierdz = new System.Windows.Forms.Button();
            this.gbOknoInicjalizacji = new System.Windows.Forms.GroupBox();
            this.lWybierzSA = new System.Windows.Forms.Label();
            this.tbNazwiskoManagera = new System.Windows.Forms.TextBox();
            this.gbOknoAvatarow = new System.Windows.Forms.GroupBox();
            this.rbManager3 = new System.Windows.Forms.RadioButton();
            this.rbManager2 = new System.Windows.Forms.RadioButton();
            this.rbManager1 = new System.Windows.Forms.RadioButton();
            this.pbManager3 = new System.Windows.Forms.PictureBox();
            this.pbManager2 = new System.Windows.Forms.PictureBox();
            this.pbManager1 = new System.Windows.Forms.PictureBox();
            this.lTwojeN = new System.Windows.Forms.Label();
            this.bOknaTreningowego = new System.Windows.Forms.Button();
            this.bZarzadzaniaZespolem = new System.Windows.Forms.Button();
            this.bStatystyki = new System.Windows.Forms.Button();
            this.bInformacje = new System.Windows.Forms.Button();
            this.flpPanelSterowania = new System.Windows.Forms.FlowLayoutPanel();
            this.pbWybranegoAvatara = new System.Windows.Forms.PictureBox();
            this.lWybraneNazwisko = new System.Windows.Forms.Label();
            this.gbOknoInicjalizacji.SuspendLayout();
            this.gbOknoAvatarow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWybranegoAvatara)).BeginInit();
            this.SuspendLayout();
            // 
            // bZatwierdz
            // 
            this.bZatwierdz.Location = new System.Drawing.Point(112, 344);
            this.bZatwierdz.Name = "bZatwierdz";
            this.bZatwierdz.Size = new System.Drawing.Size(171, 40);
            this.bZatwierdz.TabIndex = 1;
            this.bZatwierdz.Text = "Zatwierdź";
            this.bZatwierdz.UseVisualStyleBackColor = true;
            this.bZatwierdz.Click += new System.EventHandler(this.bWybierz_Click);
            // 
            // gbOknoInicjalizacji
            // 
            this.gbOknoInicjalizacji.BackColor = System.Drawing.Color.Transparent;
            this.gbOknoInicjalizacji.Controls.Add(this.lWybierzSA);
            this.gbOknoInicjalizacji.Controls.Add(this.tbNazwiskoManagera);
            this.gbOknoInicjalizacji.Controls.Add(this.gbOknoAvatarow);
            this.gbOknoInicjalizacji.Controls.Add(this.pbManager3);
            this.gbOknoInicjalizacji.Controls.Add(this.pbManager2);
            this.gbOknoInicjalizacji.Controls.Add(this.pbManager1);
            this.gbOknoInicjalizacji.Controls.Add(this.lTwojeN);
            this.gbOknoInicjalizacji.Controls.Add(this.bZatwierdz);
            this.gbOknoInicjalizacji.Location = new System.Drawing.Point(166, 71);
            this.gbOknoInicjalizacji.Name = "gbOknoInicjalizacji";
            this.gbOknoInicjalizacji.Size = new System.Drawing.Size(390, 406);
            this.gbOknoInicjalizacji.TabIndex = 4;
            this.gbOknoInicjalizacji.TabStop = false;
            // 
            // lWybierzSA
            // 
            this.lWybierzSA.AutoSize = true;
            this.lWybierzSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lWybierzSA.Location = new System.Drawing.Point(93, 109);
            this.lWybierzSA.Name = "lWybierzSA";
            this.lWybierzSA.Size = new System.Drawing.Size(205, 25);
            this.lWybierzSA.TabIndex = 10;
            this.lWybierzSA.Text = "Wybierz swój avatar";
            // 
            // tbNazwiskoManagera
            // 
            this.tbNazwiskoManagera.Location = new System.Drawing.Point(112, 64);
            this.tbNazwiskoManagera.Name = "tbNazwiskoManagera";
            this.tbNazwiskoManagera.Size = new System.Drawing.Size(171, 20);
            this.tbNazwiskoManagera.TabIndex = 9;
            this.tbNazwiskoManagera.TextChanged += new System.EventHandler(this.tbNazwiskoManagera_TextChanged);
            // 
            // gbOknoAvatarow
            // 
            this.gbOknoAvatarow.Controls.Add(this.rbManager3);
            this.gbOknoAvatarow.Controls.Add(this.rbManager2);
            this.gbOknoAvatarow.Controls.Add(this.rbManager1);
            this.gbOknoAvatarow.Location = new System.Drawing.Point(19, 303);
            this.gbOknoAvatarow.Name = "gbOknoAvatarow";
            this.gbOknoAvatarow.Size = new System.Drawing.Size(357, 35);
            this.gbOknoAvatarow.TabIndex = 8;
            this.gbOknoAvatarow.TabStop = false;
            // 
            // rbManager3
            // 
            this.rbManager3.AutoSize = true;
            this.rbManager3.Location = new System.Drawing.Point(257, 12);
            this.rbManager3.Name = "rbManager3";
            this.rbManager3.Size = new System.Drawing.Size(76, 17);
            this.rbManager3.TabIndex = 2;
            this.rbManager3.Text = "Manager 3";
            this.rbManager3.UseVisualStyleBackColor = true;
            this.rbManager3.CheckedChanged += new System.EventHandler(this.rbManager3_CheckedChanged);
            // 
            // rbManager2
            // 
            this.rbManager2.AutoSize = true;
            this.rbManager2.Location = new System.Drawing.Point(136, 12);
            this.rbManager2.Name = "rbManager2";
            this.rbManager2.Size = new System.Drawing.Size(76, 17);
            this.rbManager2.TabIndex = 1;
            this.rbManager2.Text = "Manager 2";
            this.rbManager2.UseVisualStyleBackColor = true;
            this.rbManager2.CheckedChanged += new System.EventHandler(this.rbManager2_CheckedChanged);
            // 
            // rbManager1
            // 
            this.rbManager1.AutoSize = true;
            this.rbManager1.Location = new System.Drawing.Point(17, 12);
            this.rbManager1.Name = "rbManager1";
            this.rbManager1.Size = new System.Drawing.Size(76, 17);
            this.rbManager1.TabIndex = 0;
            this.rbManager1.Text = "Manager 1";
            this.rbManager1.UseVisualStyleBackColor = true;
            this.rbManager1.CheckedChanged += new System.EventHandler(this.rbManager1_CheckedChanged);
            // 
            // pbManager3
            // 
            this.pbManager3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbManager3.BackgroundImage")));
            this.pbManager3.Location = new System.Drawing.Point(261, 164);
            this.pbManager3.Name = "pbManager3";
            this.pbManager3.Size = new System.Drawing.Size(115, 130);
            this.pbManager3.TabIndex = 7;
            this.pbManager3.TabStop = false;
            // 
            // pbManager2
            // 
            this.pbManager2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbManager2.BackgroundImage")));
            this.pbManager2.Location = new System.Drawing.Point(140, 164);
            this.pbManager2.Name = "pbManager2";
            this.pbManager2.Size = new System.Drawing.Size(115, 130);
            this.pbManager2.TabIndex = 6;
            this.pbManager2.TabStop = false;
            // 
            // pbManager1
            // 
            this.pbManager1.BackColor = System.Drawing.Color.Transparent;
            this.pbManager1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbManager1.BackgroundImage")));
            this.pbManager1.Location = new System.Drawing.Point(19, 164);
            this.pbManager1.Name = "pbManager1";
            this.pbManager1.Size = new System.Drawing.Size(115, 130);
            this.pbManager1.TabIndex = 5;
            this.pbManager1.TabStop = false;
            // 
            // lTwojeN
            // 
            this.lTwojeN.AutoSize = true;
            this.lTwojeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lTwojeN.Location = new System.Drawing.Point(119, 30);
            this.lTwojeN.Name = "lTwojeN";
            this.lTwojeN.Size = new System.Drawing.Size(164, 25);
            this.lTwojeN.TabIndex = 4;
            this.lTwojeN.Text = "Twoje nazwisko";
            // 
            // bOknaTreningowego
            // 
            this.bOknaTreningowego.Location = new System.Drawing.Point(8, 180);
            this.bOknaTreningowego.Name = "bOknaTreningowego";
            this.bOknaTreningowego.Size = new System.Drawing.Size(115, 40);
            this.bOknaTreningowego.TabIndex = 5;
            this.bOknaTreningowego.Text = "Zarządzaj Treningiem";
            this.bOknaTreningowego.UseVisualStyleBackColor = true;
            this.bOknaTreningowego.Click += new System.EventHandler(this.bOknaTreningowego_Click);
            // 
            // bZarzadzaniaZespolem
            // 
            this.bZarzadzaniaZespolem.Location = new System.Drawing.Point(8, 230);
            this.bZarzadzaniaZespolem.Name = "bZarzadzaniaZespolem";
            this.bZarzadzaniaZespolem.Size = new System.Drawing.Size(115, 40);
            this.bZarzadzaniaZespolem.TabIndex = 6;
            this.bZarzadzaniaZespolem.Text = "Zarządzaj zespołem";
            this.bZarzadzaniaZespolem.UseVisualStyleBackColor = true;
            this.bZarzadzaniaZespolem.Click += new System.EventHandler(this.bZarzadzaniaZespolem_Click);
            // 
            // bStatystyki
            // 
            this.bStatystyki.Location = new System.Drawing.Point(8, 280);
            this.bStatystyki.Name = "bStatystyki";
            this.bStatystyki.Size = new System.Drawing.Size(115, 40);
            this.bStatystyki.TabIndex = 7;
            this.bStatystyki.Text = "Statystyki";
            this.bStatystyki.UseVisualStyleBackColor = true;
            this.bStatystyki.Click += new System.EventHandler(this.bStatystyki_Click);
            // 
            // bInformacje
            // 
            this.bInformacje.Location = new System.Drawing.Point(8, 330);
            this.bInformacje.Name = "bInformacje";
            this.bInformacje.Size = new System.Drawing.Size(115, 40);
            this.bInformacje.TabIndex = 8;
            this.bInformacje.Text = "Informacje";
            this.bInformacje.UseVisualStyleBackColor = true;
            this.bInformacje.Click += new System.EventHandler(this.bInformacje_Click);
            // 
            // flpPanelSterowania
            // 
            this.flpPanelSterowania.BackColor = System.Drawing.Color.Transparent;
            this.flpPanelSterowania.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpPanelSterowania.Location = new System.Drawing.Point(129, 12);
            this.flpPanelSterowania.Name = "flpPanelSterowania";
            this.flpPanelSterowania.Size = new System.Drawing.Size(570, 550);
            this.flpPanelSterowania.TabIndex = 9;
            // 
            // pbWybranegoAvatara
            // 
            this.pbWybranegoAvatara.BackColor = System.Drawing.Color.Transparent;
            this.pbWybranegoAvatara.Location = new System.Drawing.Point(8, 12);
            this.pbWybranegoAvatara.Name = "pbWybranegoAvatara";
            this.pbWybranegoAvatara.Size = new System.Drawing.Size(115, 130);
            this.pbWybranegoAvatara.TabIndex = 10;
            this.pbWybranegoAvatara.TabStop = false;
            // 
            // lWybraneNazwisko
            // 
            this.lWybraneNazwisko.BackColor = System.Drawing.Color.Transparent;
            this.lWybraneNazwisko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lWybraneNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lWybraneNazwisko.Location = new System.Drawing.Point(8, 149);
            this.lWybraneNazwisko.Name = "lWybraneNazwisko";
            this.lWybraneNazwisko.Size = new System.Drawing.Size(115, 20);
            this.lWybraneNazwisko.TabIndex = 11;
            this.lWybraneNazwisko.Text = "Nazwisko";
            this.lWybraneNazwisko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lWybraneNazwisko.UseCompatibleTextRendering = true;
            // 
            // OknoGlowne
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 571);
            this.Controls.Add(this.lWybraneNazwisko);
            this.Controls.Add(this.pbWybranegoAvatara);
            this.Controls.Add(this.flpPanelSterowania);
            this.Controls.Add(this.bInformacje);
            this.Controls.Add(this.bStatystyki);
            this.Controls.Add(this.bZarzadzaniaZespolem);
            this.Controls.Add(this.bOknaTreningowego);
            this.Controls.Add(this.gbOknoInicjalizacji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OknoGlowne";
            this.Text = "Football Manager";
            this.gbOknoInicjalizacji.ResumeLayout(false);
            this.gbOknoInicjalizacji.PerformLayout();
            this.gbOknoAvatarow.ResumeLayout(false);
            this.gbOknoAvatarow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWybranegoAvatara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bZatwierdz;
        private System.Windows.Forms.GroupBox gbOknoInicjalizacji;
        private System.Windows.Forms.Label lTwojeN;
        private System.Windows.Forms.GroupBox gbOknoAvatarow;
        private System.Windows.Forms.RadioButton rbManager3;
        private System.Windows.Forms.RadioButton rbManager2;
        private System.Windows.Forms.PictureBox pbManager3;
        private System.Windows.Forms.PictureBox pbManager2;
        private System.Windows.Forms.PictureBox pbManager1;
        private System.Windows.Forms.RadioButton rbManager1;
        private System.Windows.Forms.TextBox tbNazwiskoManagera;
        private System.Windows.Forms.Button bOknaTreningowego;
        private System.Windows.Forms.Button bZarzadzaniaZespolem;
        private System.Windows.Forms.Button bStatystyki;
        private System.Windows.Forms.Button bInformacje;
        private System.Windows.Forms.FlowLayoutPanel flpPanelSterowania;
        private System.Windows.Forms.Label lWybierzSA;
        private System.Windows.Forms.PictureBox pbWybranegoAvatara;
        private System.Windows.Forms.Label lWybraneNazwisko;
    }
}

