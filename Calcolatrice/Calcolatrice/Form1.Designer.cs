namespace Calcolatrice
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_schermo = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.tbl_numbersContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_più = new System.Windows.Forms.Button();
            this.btn_per = new System.Windows.Forms.Button();
            this.btn_diviso = new System.Windows.Forms.Button();
            this.btn_meno = new System.Windows.Forms.Button();
            this.tbl_numbersContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_schermo
            // 
            this.lbl_schermo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_schermo.Location = new System.Drawing.Point(354, 150);
            this.lbl_schermo.Name = "lbl_schermo";
            this.lbl_schermo.Size = new System.Drawing.Size(122, 23);
            this.lbl_schermo.TabIndex = 0;
            this.lbl_schermo.Click += new System.EventHandler(this.lbl_schermo_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_1.Location = new System.Drawing.Point(3, 3);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(24, 23);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // tbl_numbersContainer
            // 
            this.tbl_numbersContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbl_numbersContainer.ColumnCount = 3;
            this.tbl_numbersContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_numbersContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_numbersContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_numbersContainer.Controls.Add(this.btn_1, 0, 0);
            this.tbl_numbersContainer.Controls.Add(this.btn_2, 1, 0);
            this.tbl_numbersContainer.Controls.Add(this.btn_3, 2, 0);
            this.tbl_numbersContainer.Controls.Add(this.btn_6, 2, 1);
            this.tbl_numbersContainer.Controls.Add(this.btn_7, 0, 2);
            this.tbl_numbersContainer.Controls.Add(this.btn_8, 1, 2);
            this.tbl_numbersContainer.Controls.Add(this.btn_9, 2, 2);
            this.tbl_numbersContainer.Controls.Add(this.btn_4, 1, 1);
            this.tbl_numbersContainer.Controls.Add(this.btn_5, 0, 1);
            this.tbl_numbersContainer.Controls.Add(this.btn_punto, 0, 3);
            this.tbl_numbersContainer.Controls.Add(this.btn_0, 1, 3);
            this.tbl_numbersContainer.Controls.Add(this.btn_backspace, 2, 3);
            this.tbl_numbersContainer.Location = new System.Drawing.Point(354, 176);
            this.tbl_numbersContainer.Name = "tbl_numbersContainer";
            this.tbl_numbersContainer.RowCount = 4;
            this.tbl_numbersContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_numbersContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_numbersContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_numbersContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_numbersContainer.Size = new System.Drawing.Size(89, 118);
            this.tbl_numbersContainer.TabIndex = 3;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(33, 3);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(24, 23);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(63, 3);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(24, 23);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(63, 33);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(24, 23);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(3, 63);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(24, 23);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(33, 63);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(24, 23);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(63, 63);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(24, 23);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(33, 33);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(24, 23);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(3, 33);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(24, 23);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_punto
            // 
            this.btn_punto.Location = new System.Drawing.Point(3, 93);
            this.btn_punto.Name = "btn_punto";
            this.btn_punto.Size = new System.Drawing.Size(24, 23);
            this.btn_punto.TabIndex = 10;
            this.btn_punto.Text = ".";
            this.btn_punto.UseVisualStyleBackColor = true;
            this.btn_punto.Click += new System.EventHandler(this.btn_punto_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(33, 93);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(24, 23);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.Location = new System.Drawing.Point(63, 93);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(24, 23);
            this.btn_backspace.TabIndex = 12;
            this.btn_backspace.Text = "⌫";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_più, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_per, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_diviso, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_meno, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(449, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(29, 118);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_più
            // 
            this.btn_più.Location = new System.Drawing.Point(3, 3);
            this.btn_più.Name = "btn_più";
            this.btn_più.Size = new System.Drawing.Size(24, 23);
            this.btn_più.TabIndex = 0;
            this.btn_più.Text = "+";
            this.btn_più.UseVisualStyleBackColor = true;
            this.btn_più.Click += new System.EventHandler(this.btn_più_Click);
            // 
            // btn_per
            // 
            this.btn_per.Location = new System.Drawing.Point(3, 63);
            this.btn_per.Name = "btn_per";
            this.btn_per.Size = new System.Drawing.Size(24, 23);
            this.btn_per.TabIndex = 2;
            this.btn_per.Text = "x";
            this.btn_per.UseVisualStyleBackColor = true;
            this.btn_per.Click += new System.EventHandler(this.btn_per_Click);
            // 
            // btn_diviso
            // 
            this.btn_diviso.Location = new System.Drawing.Point(3, 93);
            this.btn_diviso.Name = "btn_diviso";
            this.btn_diviso.Size = new System.Drawing.Size(24, 23);
            this.btn_diviso.TabIndex = 3;
            this.btn_diviso.Text = "÷";
            this.btn_diviso.UseVisualStyleBackColor = true;
            this.btn_diviso.Click += new System.EventHandler(this.btn_diviso_Click);
            // 
            // btn_meno
            // 
            this.btn_meno.Location = new System.Drawing.Point(3, 33);
            this.btn_meno.Name = "btn_meno";
            this.btn_meno.Size = new System.Drawing.Size(24, 23);
            this.btn_meno.TabIndex = 1;
            this.btn_meno.Text = "-";
            this.btn_meno.UseVisualStyleBackColor = true;
            this.btn_meno.Click += new System.EventHandler(this.btn_meno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tbl_numbersContainer);
            this.Controls.Add(this.lbl_schermo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbl_numbersContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_schermo;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TableLayoutPanel tbl_numbersContainer;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_punto;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_più;
        private System.Windows.Forms.Button btn_per;
        private System.Windows.Forms.Button btn_diviso;
        private System.Windows.Forms.Button btn_meno;
    }
}

