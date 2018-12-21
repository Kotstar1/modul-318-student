namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstStation = new System.Windows.Forms.ListBox();
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.GUI = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstNach = new System.Windows.Forms.ListBox();
            this.lstVon = new System.Windows.Forms.ListBox();
            this.txtNach = new System.Windows.Forms.TextBox();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.dgvAnzeige = new System.Windows.Forms.DataGridView();
            this.btnGooglemaps = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnVerbindungsuchen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webGoogleMaps = new System.Windows.Forms.WebBrowser();
            this.btnMapReset = new System.Windows.Forms.Button();
            this.btnNear = new System.Windows.Forms.Button();
            this.pbSwitch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.GUI.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstStation);
            this.panel2.Controls.Add(this.dgvAbfahrtstafel);
            this.panel2.Controls.Add(this.btnAbfahrtstafel);
            this.panel2.Controls.Add(this.txtStation);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(135, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 380);
            this.panel2.TabIndex = 48;
            // 
            // lstStation
            // 
            this.lstStation.FormattingEnabled = true;
            this.lstStation.Location = new System.Drawing.Point(40, 133);
            this.lstStation.Name = "lstStation";
            this.lstStation.Size = new System.Drawing.Size(178, 95);
            this.lstStation.TabIndex = 4;
            this.lstStation.Visible = false;
            this.lstStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstStation_KeyDown);
            this.lstStation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstStation_MouseDoubleClick);
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(40, 166);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(352, 193);
            this.dgvAbfahrtstafel.TabIndex = 5;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(245, 112);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(147, 23);
            this.btnAbfahrtstafel.TabIndex = 5;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel erstellen";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(40, 114);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(178, 20);
            this.txtStation.TabIndex = 3;
            this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            this.txtStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStation_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 64);
            this.label5.TabIndex = 0;
            this.label5.Text = "Abfahrtstafel";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(614, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 21);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GUI
            // 
            this.GUI.AccessibleDescription = "";
            this.GUI.AccessibleName = "";
            this.GUI.Controls.Add(this.tabPage1);
            this.GUI.Controls.Add(this.tabPage2);
            this.GUI.Controls.Add(this.tabPage3);
            this.GUI.Location = new System.Drawing.Point(7, 12);
            this.GUI.Name = "GUI";
            this.GUI.SelectedIndex = 0;
            this.GUI.Size = new System.Drawing.Size(693, 492);
            this.GUI.TabIndex = 51;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnback);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fahrplan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNear);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pbSwitch);
            this.panel1.Controls.Add(this.lstNach);
            this.panel1.Controls.Add(this.lstVon);
            this.panel1.Controls.Add(this.txtNach);
            this.panel1.Controls.Add(this.txtVon);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnEmail);
            this.panel1.Controls.Add(this.dgvAnzeige);
            this.panel1.Controls.Add(this.btnGooglemaps);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpDatum);
            this.panel1.Controls.Add(this.btnVerbindungsuchen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 475);
            this.panel1.TabIndex = 7;
            // 
            // lstNach
            // 
            this.lstNach.FormattingEnabled = true;
            this.lstNach.Location = new System.Drawing.Point(236, 75);
            this.lstNach.Name = "lstNach";
            this.lstNach.Size = new System.Drawing.Size(143, 95);
            this.lstNach.TabIndex = 7;
            this.lstNach.Visible = false;
            this.lstNach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstNach_KeyDown);
            this.lstNach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstNach_MouseDoubleClick);
            // 
            // lstVon
            // 
            this.lstVon.FormattingEnabled = true;
            this.lstVon.Location = new System.Drawing.Point(20, 75);
            this.lstVon.Name = "lstVon";
            this.lstVon.Size = new System.Drawing.Size(143, 95);
            this.lstVon.TabIndex = 5;
            this.lstVon.Visible = false;
            this.lstVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstVon_KeyDown);
            this.lstVon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVon_MouseDoubleClick);
            // 
            // txtNach
            // 
            this.txtNach.Location = new System.Drawing.Point(236, 58);
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(143, 20);
            this.txtNach.TabIndex = 6;
            this.txtNach.TextChanged += new System.EventHandler(this.txtNach_TextChanged);
            this.txtNach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNach_KeyDown);
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(20, 58);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(143, 20);
            this.txtVon.TabIndex = 4;
            this.txtVon.TextChanged += new System.EventHandler(this.txtVon_TextChanged);
            this.txtVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVon_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(173, 388);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(20, 385);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(143, 23);
            this.btnEmail.TabIndex = 12;
            this.btnEmail.Text = "Fahrplan per Email senden";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // dgvAnzeige
            // 
            this.dgvAnzeige.AllowUserToAddRows = false;
            this.dgvAnzeige.AllowUserToDeleteRows = false;
            this.dgvAnzeige.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAnzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnzeige.Location = new System.Drawing.Point(20, 186);
            this.dgvAnzeige.Name = "dgvAnzeige";
            this.dgvAnzeige.ReadOnly = true;
            this.dgvAnzeige.Size = new System.Drawing.Size(636, 168);
            this.dgvAnzeige.TabIndex = 46;
            // 
            // btnGooglemaps
            // 
            this.btnGooglemaps.Location = new System.Drawing.Point(403, 92);
            this.btnGooglemaps.Name = "btnGooglemaps";
            this.btnGooglemaps.Size = new System.Drawing.Size(253, 23);
            this.btnGooglemaps.TabIndex = 11;
            this.btnGooglemaps.Text = "Auf Google Maps ansehen ";
            this.btnGooglemaps.UseVisualStyleBackColor = true;
            this.btnGooglemaps.Click += new System.EventHandler(this.btnGooglemaps_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Zeit";
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(236, 139);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(70, 22);
            this.dtpTime.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Datum";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.CustomFormat = "dd.MM.yyyy";
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(20, 138);
            this.dtpDatum.MinDate = new System.DateTime(2018, 12, 21, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(143, 22);
            this.dtpDatum.TabIndex = 8;
            // 
            // btnVerbindungsuchen
            // 
            this.btnVerbindungsuchen.Location = new System.Drawing.Point(403, 58);
            this.btnVerbindungsuchen.Name = "btnVerbindungsuchen";
            this.btnVerbindungsuchen.Size = new System.Drawing.Size(253, 23);
            this.btnVerbindungsuchen.TabIndex = 10;
            this.btnVerbindungsuchen.Text = "Verbindung suchen";
            this.btnVerbindungsuchen.UseVisualStyleBackColor = true;
            this.btnVerbindungsuchen.Click += new System.EventHandler(this.btnVerbindungsuchen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Von";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(528, 437);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(125, 23);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMapReset);
            this.tabPage3.Controls.Add(this.webGoogleMaps);
            this.tabPage3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(685, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Google Maps";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // webGoogleMaps
            // 
            this.webGoogleMaps.Location = new System.Drawing.Point(3, 3);
            this.webGoogleMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.webGoogleMaps.Name = "webGoogleMaps";
            this.webGoogleMaps.ScriptErrorsSuppressed = true;
            this.webGoogleMaps.Size = new System.Drawing.Size(673, 454);
            this.webGoogleMaps.TabIndex = 7;
            this.webGoogleMaps.Url = new System.Uri("https://www.google.com/maps/", System.UriKind.Absolute);
            // 
            // btnMapReset
            // 
            this.btnMapReset.Location = new System.Drawing.Point(575, 0);
            this.btnMapReset.Name = "btnMapReset";
            this.btnMapReset.Size = new System.Drawing.Size(110, 40);
            this.btnMapReset.TabIndex = 8;
            this.btnMapReset.Text = "Map zurücksetzten";
            this.btnMapReset.UseVisualStyleBackColor = true;
            this.btnMapReset.Click += new System.EventHandler(this.btnMapReset_Click);
            // 
            // btnNear
            // 
            this.btnNear.Location = new System.Drawing.Point(403, 123);
            this.btnNear.Name = "btnNear";
            this.btnNear.Size = new System.Drawing.Size(253, 23);
            this.btnNear.TabIndex = 49;
            this.btnNear.Text = "Stationen in der Nähe";
            this.btnNear.UseVisualStyleBackColor = true;
            this.btnNear.Click += new System.EventHandler(this.btnNear_Click);
            // 
            // pbSwitch
            // 
            this.pbSwitch.Image = global::GUI.Properties.Resources.switch1;
            this.pbSwitch.Location = new System.Drawing.Point(173, 42);
            this.pbSwitch.Name = "pbSwitch";
            this.pbSwitch.Size = new System.Drawing.Size(57, 46);
            this.pbSwitch.TabIndex = 48;
            this.pbSwitch.TabStop = false;
            this.pbSwitch.Click += new System.EventHandler(this.pbSwitch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons3;
            this.pictureBox1.Location = new System.Drawing.Point(281, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 61);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 518);
            this.Controls.Add(this.GUI);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            this.GUI.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAbfahrtstafel;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstStation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl GUI;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSwitch;
        private System.Windows.Forms.ListBox lstNach;
        private System.Windows.Forms.ListBox lstVon;
        private System.Windows.Forms.TextBox txtNach;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.DataGridView dgvAnzeige;
        private System.Windows.Forms.Button btnGooglemaps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnVerbindungsuchen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webGoogleMaps;
        private System.Windows.Forms.Button btnMapReset;
        private System.Windows.Forms.Button btnNear;
    }
}

