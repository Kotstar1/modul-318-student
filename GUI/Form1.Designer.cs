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
            this.btnGooglemaps2 = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnFahrplan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnGooglemaps2);
            this.panel1.Controls.Add(this.btnAbfahrtstafel);
            this.panel1.Controls.Add(this.btnFahrplan);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 536);
            this.panel1.TabIndex = 0;
            // 
            // lstNach
            // 
            this.lstNach.FormattingEnabled = true;
            this.lstNach.Location = new System.Drawing.Point(217, 121);
            this.lstNach.Name = "lstNach";
            this.lstNach.Size = new System.Drawing.Size(143, 95);
            this.lstNach.TabIndex = 52;
            this.lstNach.Visible = false;
            this.lstNach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstNach_MouseDoubleClick);
            // 
            // lstVon
            // 
            this.lstVon.FormattingEnabled = true;
            this.lstVon.Location = new System.Drawing.Point(29, 121);
            this.lstVon.Name = "lstVon";
            this.lstVon.Size = new System.Drawing.Size(143, 95);
            this.lstVon.TabIndex = 51;
            this.lstVon.Visible = false;
            this.lstVon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVon_MouseDoubleClick);
            // 
            // txtNach
            // 
            this.txtNach.Location = new System.Drawing.Point(217, 104);
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(143, 20);
            this.txtNach.TabIndex = 50;
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(29, 104);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(143, 20);
            this.txtVon.TabIndex = 49;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(199, 496);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 48;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(29, 494);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(143, 23);
            this.btnEmail.TabIndex = 47;
            this.btnEmail.Text = "Fahrplan per Email senden";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // dgvAnzeige
            // 
            this.dgvAnzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnzeige.Location = new System.Drawing.Point(29, 232);
            this.dgvAnzeige.Name = "dgvAnzeige";
            this.dgvAnzeige.Size = new System.Drawing.Size(500, 245);
            this.dgvAnzeige.TabIndex = 46;
            // 
            // btnGooglemaps
            // 
            this.btnGooglemaps.Location = new System.Drawing.Point(381, 169);
            this.btnGooglemaps.Name = "btnGooglemaps";
            this.btnGooglemaps.Size = new System.Drawing.Size(148, 23);
            this.btnGooglemaps.TabIndex = 45;
            this.btnGooglemaps.Text = "Auf Google Maps ansehen ";
            this.btnGooglemaps.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 169);
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
            this.dtpTime.Location = new System.Drawing.Point(217, 185);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(70, 22);
            this.dtpTime.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 169);
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
            this.dtpDatum.Location = new System.Drawing.Point(29, 185);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(143, 22);
            this.dtpDatum.TabIndex = 40;
            // 
            // btnVerbindungsuchen
            // 
            this.btnVerbindungsuchen.Location = new System.Drawing.Point(381, 104);
            this.btnVerbindungsuchen.Name = "btnVerbindungsuchen";
            this.btnVerbindungsuchen.Size = new System.Drawing.Size(148, 23);
            this.btnVerbindungsuchen.TabIndex = 42;
            this.btnVerbindungsuchen.Text = "Verbindung suchen";
            this.btnVerbindungsuchen.UseVisualStyleBackColor = true;
            this.btnVerbindungsuchen.Click += new System.EventHandler(this.btnVerbindungsuchen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Von";
            // 
            // btnGooglemaps2
            // 
            this.btnGooglemaps2.Location = new System.Drawing.Point(368, 13);
            this.btnGooglemaps2.Name = "btnGooglemaps2";
            this.btnGooglemaps2.Size = new System.Drawing.Size(161, 51);
            this.btnGooglemaps2.TabIndex = 37;
            this.btnGooglemaps2.Text = "Google Maps";
            this.btnGooglemaps2.UseVisualStyleBackColor = true;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(199, 13);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(161, 51);
            this.btnAbfahrtstafel.TabIndex = 36;
            this.btnAbfahrtstafel.Text = "Abfhartstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            // 
            // btnFahrplan
            // 
            this.btnFahrplan.Location = new System.Drawing.Point(29, 13);
            this.btnFahrplan.Name = "btnFahrplan";
            this.btnFahrplan.Size = new System.Drawing.Size(161, 51);
            this.btnFahrplan.TabIndex = 35;
            this.btnFahrplan.Text = "Fahrplan";
            this.btnFahrplan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 619);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button btnGooglemaps2;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnFahrplan;
    }
}

