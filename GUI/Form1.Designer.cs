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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGooglemaps = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnVerbindung = new System.Windows.Forms.Button();
            this.txtNach = new System.Windows.Forms.TextBox();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGooglemaps2 = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnFahrplan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(199, 495);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 30;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(29, 493);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(143, 23);
            this.btnEmail.TabIndex = 29;
            this.btnEmail.Text = "Fahrplan per Email senden";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 245);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnGooglemaps
            // 
            this.btnGooglemaps.Location = new System.Drawing.Point(381, 183);
            this.btnGooglemaps.Name = "btnGooglemaps";
            this.btnGooglemaps.Size = new System.Drawing.Size(148, 23);
            this.btnGooglemaps.TabIndex = 27;
            this.btnGooglemaps.Text = "Auf Google Maps ansehen ";
            this.btnGooglemaps.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Zeit";
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(217, 184);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(70, 22);
            this.dtpTime.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Datum";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.CustomFormat = "dd.MM.yyyy";
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(29, 184);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(143, 22);
            this.dtpDatum.TabIndex = 21;
            // 
            // btnVerbindung
            // 
            this.btnVerbindung.Location = new System.Drawing.Point(381, 120);
            this.btnVerbindung.Name = "btnVerbindung";
            this.btnVerbindung.Size = new System.Drawing.Size(148, 23);
            this.btnVerbindung.TabIndex = 24;
            this.btnVerbindung.Text = "Verbindung suchen";
            this.btnVerbindung.UseVisualStyleBackColor = true;
            // 
            // txtNach
            // 
            this.txtNach.Location = new System.Drawing.Point(217, 122);
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(143, 20);
            this.txtNach.TabIndex = 22;
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(29, 122);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(143, 20);
            this.txtVon.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Von";
            // 
            // btnGooglemaps2
            // 
            this.btnGooglemaps2.Location = new System.Drawing.Point(368, 12);
            this.btnGooglemaps2.Name = "btnGooglemaps2";
            this.btnGooglemaps2.Size = new System.Drawing.Size(161, 51);
            this.btnGooglemaps2.TabIndex = 17;
            this.btnGooglemaps2.Text = "Google Maps";
            this.btnGooglemaps2.UseVisualStyleBackColor = true;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(199, 12);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(161, 51);
            this.btnAbfahrtstafel.TabIndex = 16;
            this.btnAbfahrtstafel.Text = "Abfhartstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            // 
            // btnFahrplan
            // 
            this.btnFahrplan.Location = new System.Drawing.Point(29, 12);
            this.btnFahrplan.Name = "btnFahrplan";
            this.btnFahrplan.Size = new System.Drawing.Size(161, 51);
            this.btnFahrplan.TabIndex = 15;
            this.btnFahrplan.Text = "Fahrplan";
            this.btnFahrplan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 535);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGooglemaps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnVerbindung);
            this.Controls.Add(this.txtNach);
            this.Controls.Add(this.txtVon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGooglemaps2);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnFahrplan);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGooglemaps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnVerbindung;
        private System.Windows.Forms.TextBox txtNach;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGooglemaps2;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnFahrplan;
    }
}

