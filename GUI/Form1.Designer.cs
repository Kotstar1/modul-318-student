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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panelnav = new System.Windows.Forms.Panel();
            this.btnNavGooglemaps = new System.Windows.Forms.Button();
            this.btnNavAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnNavfahrplan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webGoogleMaps = new System.Windows.Forms.WebBrowser();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).BeginInit();
            this.panelnav.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(12, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 426);
            this.panel2.TabIndex = 48;
            this.panel2.Visible = false;
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
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(40, 170);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(478, 193);
            this.dgvAbfahrtstafel.TabIndex = 5;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(323, 114);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(195, 23);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons;
            this.pictureBox1.Location = new System.Drawing.Point(323, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 475);
            this.panel1.TabIndex = 6;
            // 
            // lstNach
            // 
            this.lstNach.FormattingEnabled = true;
            this.lstNach.Location = new System.Drawing.Point(244, 45);
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
            this.lstVon.Location = new System.Drawing.Point(28, 45);
            this.lstVon.Name = "lstVon";
            this.lstVon.Size = new System.Drawing.Size(143, 95);
            this.lstVon.TabIndex = 5;
            this.lstVon.Visible = false;
            this.lstVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstVon_KeyDown);
            this.lstVon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVon_MouseDoubleClick);
            // 
            // txtNach
            // 
            this.txtNach.Location = new System.Drawing.Point(244, 28);
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(143, 20);
            this.txtNach.TabIndex = 6;
            this.txtNach.TextChanged += new System.EventHandler(this.txtNach_TextChanged);
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(28, 28);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(143, 20);
            this.txtVon.TabIndex = 4;
            this.txtVon.TextChanged += new System.EventHandler(this.txtVon_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(198, 420);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(28, 418);
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
            this.dgvAnzeige.Location = new System.Drawing.Point(28, 156);
            this.dgvAnzeige.Name = "dgvAnzeige";
            this.dgvAnzeige.ReadOnly = true;
            this.dgvAnzeige.Size = new System.Drawing.Size(636, 245);
            this.dgvAnzeige.TabIndex = 46;
            // 
            // btnGooglemaps
            // 
            this.btnGooglemaps.Location = new System.Drawing.Point(411, 117);
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
            this.label4.Location = new System.Drawing.Point(241, 93);
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
            this.dtpTime.Location = new System.Drawing.Point(244, 109);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(70, 22);
            this.dtpTime.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
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
            this.dtpDatum.Location = new System.Drawing.Point(28, 108);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(143, 22);
            this.dtpDatum.TabIndex = 8;
            // 
            // btnVerbindungsuchen
            // 
            this.btnVerbindungsuchen.Location = new System.Drawing.Point(411, 28);
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
            this.label2.Location = new System.Drawing.Point(241, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Von";
            // 
            // panelnav
            // 
            this.panelnav.Controls.Add(this.btnNavGooglemaps);
            this.panelnav.Controls.Add(this.btnNavAbfahrtstafel);
            this.panelnav.Controls.Add(this.btnNavfahrplan);
            this.panelnav.Location = new System.Drawing.Point(12, 12);
            this.panelnav.Name = "panelnav";
            this.panelnav.Size = new System.Drawing.Size(670, 78);
            this.panelnav.TabIndex = 49;
            // 
            // btnNavGooglemaps
            // 
            this.btnNavGooglemaps.Location = new System.Drawing.Point(459, 19);
            this.btnNavGooglemaps.Name = "btnNavGooglemaps";
            this.btnNavGooglemaps.Size = new System.Drawing.Size(205, 51);
            this.btnNavGooglemaps.TabIndex = 6;
            this.btnNavGooglemaps.Text = "Google Maps";
            this.btnNavGooglemaps.UseVisualStyleBackColor = true;
            // 
            // btnNavAbfahrtstafel
            // 
            this.btnNavAbfahrtstafel.Location = new System.Drawing.Point(244, 19);
            this.btnNavAbfahrtstafel.Name = "btnNavAbfahrtstafel";
            this.btnNavAbfahrtstafel.Size = new System.Drawing.Size(209, 51);
            this.btnNavAbfahrtstafel.TabIndex = 5;
            this.btnNavAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnNavAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnNavAbfahrtstafel.Click += new System.EventHandler(this.btnNavAbfahrtstafel_Click);
            // 
            // btnNavfahrplan
            // 
            this.btnNavfahrplan.Location = new System.Drawing.Point(28, 19);
            this.btnNavfahrplan.Name = "btnNavfahrplan";
            this.btnNavfahrplan.Size = new System.Drawing.Size(210, 51);
            this.btnNavfahrplan.TabIndex = 4;
            this.btnNavfahrplan.Text = "Fahrplan";
            this.btnNavfahrplan.UseVisualStyleBackColor = true;
            this.btnNavfahrplan.Click += new System.EventHandler(this.btnNavfahrplan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webGoogleMaps);
            this.panel3.Location = new System.Drawing.Point(40, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 475);
            this.panel3.TabIndex = 50;
            this.panel3.Visible = false;
            // 
            // webGoogleMaps
            // 
            this.webGoogleMaps.Location = new System.Drawing.Point(0, 7);
            this.webGoogleMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.webGoogleMaps.Name = "webGoogleMaps";
            this.webGoogleMaps.ScriptErrorsSuppressed = true;
            this.webGoogleMaps.Size = new System.Drawing.Size(618, 468);
            this.webGoogleMaps.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 790);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelnav);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).EndInit();
            this.panelnav.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panelnav;
        private System.Windows.Forms.Button btnNavGooglemaps;
        private System.Windows.Forms.Button btnNavAbfahrtstafel;
        private System.Windows.Forms.Button btnNavfahrplan;
        private System.Windows.Forms.ListBox lstStation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.WebBrowser webGoogleMaps;
    }
}

