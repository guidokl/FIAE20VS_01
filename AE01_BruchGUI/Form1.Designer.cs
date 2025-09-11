namespace AE01_BruchGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbZaehler1 = new TextBox();
            tbNenner1 = new TextBox();
            tbNenner2 = new TextBox();
            tbZaehler2 = new TextBox();
            tbErgNenner = new TextBox();
            tbErgZaehler = new TextBox();
            btnAdd = new Button();
            btnDif = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // tbZaehler1
            // 
            tbZaehler1.Font = new Font("Segoe UI", 18F);
            tbZaehler1.Location = new Point(62, 52);
            tbZaehler1.Name = "tbZaehler1";
            tbZaehler1.Size = new Size(100, 39);
            tbZaehler1.TabIndex = 0;
            tbZaehler1.Text = "1";
            // 
            // tbNenner1
            // 
            tbNenner1.Font = new Font("Segoe UI", 18F);
            tbNenner1.Location = new Point(62, 101);
            tbNenner1.Name = "tbNenner1";
            tbNenner1.Size = new Size(100, 39);
            tbNenner1.TabIndex = 1;
            tbNenner1.Text = "2";
            // 
            // tbNenner2
            // 
            tbNenner2.Font = new Font("Segoe UI", 18F);
            tbNenner2.Location = new Point(210, 101);
            tbNenner2.Name = "tbNenner2";
            tbNenner2.Size = new Size(100, 39);
            tbNenner2.TabIndex = 3;
            tbNenner2.Text = "4";
            // 
            // tbZaehler2
            // 
            tbZaehler2.Font = new Font("Segoe UI", 18F);
            tbZaehler2.Location = new Point(210, 52);
            tbZaehler2.Name = "tbZaehler2";
            tbZaehler2.Size = new Size(100, 39);
            tbZaehler2.TabIndex = 2;
            tbZaehler2.Text = "1";
            // 
            // tbErgNenner
            // 
            tbErgNenner.Font = new Font("Segoe UI", 18F);
            tbErgNenner.Location = new Point(451, 101);
            tbErgNenner.Name = "tbErgNenner";
            tbErgNenner.Size = new Size(100, 39);
            tbErgNenner.TabIndex = 5;
            // 
            // tbErgZaehler
            // 
            tbErgZaehler.Font = new Font("Segoe UI", 18F);
            tbErgZaehler.Location = new Point(451, 52);
            tbErgZaehler.Name = "tbErgZaehler";
            tbErgZaehler.Size = new Size(100, 39);
            tbErgZaehler.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 18F);
            btnAdd.Location = new Point(345, 54);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 37);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += SuperEvent3000;
            // 
            // btnDif
            // 
            btnDif.Font = new Font("Segoe UI", 18F);
            btnDif.Location = new Point(345, 101);
            btnDif.Name = "btnDif";
            btnDif.Size = new Size(75, 39);
            btnDif.TabIndex = 7;
            btnDif.Text = "-";
            btnDif.UseVisualStyleBackColor = true;
            btnDif.Click += SuperEvent3000;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 18F);
            btnMult.Location = new Point(345, 158);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 49);
            btnMult.TabIndex = 8;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += SuperEvent3000;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 18F);
            btnDiv.Location = new Point(345, 213);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 43);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += SuperEvent3000;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(328, 296);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnDif);
            Controls.Add(btnAdd);
            Controls.Add(tbErgNenner);
            Controls.Add(tbErgZaehler);
            Controls.Add(tbNenner2);
            Controls.Add(tbZaehler2);
            Controls.Add(tbNenner1);
            Controls.Add(tbZaehler1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbZaehler1;
        private TextBox tbNenner1;
        private TextBox tbNenner2;
        private TextBox tbZaehler2;
        private TextBox tbErgNenner;
        private TextBox tbErgZaehler;
        private Button btnAdd;
        private Button btnDif;
        private Button btnMult;
        private Button btnDiv;
        private ComboBox comboBox1;
    }
}

