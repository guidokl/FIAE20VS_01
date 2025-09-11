namespace AE02_VectorGUI
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tbVec1_a = new TextBox();
            tbVec1_b = new TextBox();
            tbVec1_c = new TextBox();
            tbVec1_d = new TextBox();
            tbVec1_e = new TextBox();
            tbVec2_a = new TextBox();
            tbVec2_b = new TextBox();
            tbVec2_c = new TextBox();
            tbVec2_d = new TextBox();
            tbVec2_e = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            tbVecErg_a = new TextBox();
            tbVecErg_b = new TextBox();
            tbVecErg_c = new TextBox();
            tbVecErg_d = new TextBox();
            tbVecErg_e = new TextBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 164);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(258, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(208, 17);
            toolStripStatusLabel1.Text = "All engines running, systems nominal.";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // tbVec1_a
            // 
            tbVec1_a.Location = new Point(12, 12);
            tbVec1_a.Name = "tbVec1_a";
            tbVec1_a.Size = new Size(61, 23);
            tbVec1_a.TabIndex = 1;
            // 
            // tbVec1_b
            // 
            tbVec1_b.Location = new Point(12, 41);
            tbVec1_b.Name = "tbVec1_b";
            tbVec1_b.Size = new Size(61, 23);
            tbVec1_b.TabIndex = 1;
            // 
            // tbVec1_c
            // 
            tbVec1_c.Location = new Point(12, 70);
            tbVec1_c.Name = "tbVec1_c";
            tbVec1_c.Size = new Size(61, 23);
            tbVec1_c.TabIndex = 1;
            // 
            // tbVec1_d
            // 
            tbVec1_d.Location = new Point(12, 99);
            tbVec1_d.Name = "tbVec1_d";
            tbVec1_d.Size = new Size(61, 23);
            tbVec1_d.TabIndex = 1;
            // 
            // tbVec1_e
            // 
            tbVec1_e.Location = new Point(12, 128);
            tbVec1_e.Name = "tbVec1_e";
            tbVec1_e.Size = new Size(61, 23);
            tbVec1_e.TabIndex = 1;
            // 
            // tbVec2_a
            // 
            tbVec2_a.Location = new Point(79, 12);
            tbVec2_a.Name = "tbVec2_a";
            tbVec2_a.Size = new Size(61, 23);
            tbVec2_a.TabIndex = 1;
            // 
            // tbVec2_b
            // 
            tbVec2_b.Location = new Point(79, 41);
            tbVec2_b.Name = "tbVec2_b";
            tbVec2_b.Size = new Size(61, 23);
            tbVec2_b.TabIndex = 1;
            // 
            // tbVec2_c
            // 
            tbVec2_c.Location = new Point(79, 70);
            tbVec2_c.Name = "tbVec2_c";
            tbVec2_c.Size = new Size(61, 23);
            tbVec2_c.TabIndex = 1;
            // 
            // tbVec2_d
            // 
            tbVec2_d.Location = new Point(79, 99);
            tbVec2_d.Name = "tbVec2_d";
            tbVec2_d.Size = new Size(61, 23);
            tbVec2_d.TabIndex = 1;
            // 
            // tbVec2_e
            // 
            tbVec2_e.Location = new Point(79, 128);
            tbVec2_e.Name = "tbVec2_e";
            tbVec2_e.Size = new Size(61, 23);
            tbVec2_e.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(146, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(33, 27);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(146, 53);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(33, 27);
            btnSub.TabIndex = 2;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(146, 86);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(33, 27);
            btnMul.TabIndex = 2;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(146, 119);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(33, 27);
            btnDiv.TabIndex = 2;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // tbVecErg_a
            // 
            tbVecErg_a.Location = new Point(185, 12);
            tbVecErg_a.Name = "tbVecErg_a";
            tbVecErg_a.Size = new Size(61, 23);
            tbVecErg_a.TabIndex = 1;
            // 
            // tbVecErg_b
            // 
            tbVecErg_b.Location = new Point(185, 41);
            tbVecErg_b.Name = "tbVecErg_b";
            tbVecErg_b.Size = new Size(61, 23);
            tbVecErg_b.TabIndex = 1;
            // 
            // tbVecErg_c
            // 
            tbVecErg_c.Location = new Point(185, 70);
            tbVecErg_c.Name = "tbVecErg_c";
            tbVecErg_c.Size = new Size(61, 23);
            tbVecErg_c.TabIndex = 1;
            // 
            // tbVecErg_d
            // 
            tbVecErg_d.Location = new Point(185, 99);
            tbVecErg_d.Name = "tbVecErg_d";
            tbVecErg_d.Size = new Size(61, 23);
            tbVecErg_d.TabIndex = 1;
            // 
            // tbVecErg_e
            // 
            tbVecErg_e.Location = new Point(185, 128);
            tbVecErg_e.Name = "tbVecErg_e";
            tbVecErg_e.Size = new Size(61, 23);
            tbVecErg_e.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 186);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(tbVecErg_e);
            Controls.Add(tbVecErg_d);
            Controls.Add(tbVecErg_c);
            Controls.Add(tbVecErg_b);
            Controls.Add(tbVecErg_a);
            Controls.Add(tbVec2_e);
            Controls.Add(tbVec2_d);
            Controls.Add(tbVec2_c);
            Controls.Add(tbVec2_b);
            Controls.Add(tbVec2_a);
            Controls.Add(tbVec1_e);
            Controls.Add(tbVec1_d);
            Controls.Add(tbVec1_c);
            Controls.Add(tbVec1_b);
            Controls.Add(tbVec1_a);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Void's VectorCalc";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private TextBox tbVec1_a;
        private TextBox tbVec1_b;
        private TextBox tbVec1_c;
        private TextBox tbVec1_d;
        private TextBox tbVec1_e;
        private TextBox tbVec2_a;
        private TextBox tbVec2_b;
        private TextBox tbVec2_c;
        private TextBox tbVec2_d;
        private TextBox tbVec2_e;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private TextBox tbVecErg_a;
        private TextBox tbVecErg_b;
        private TextBox tbVecErg_c;
        private TextBox tbVecErg_d;
        private TextBox tbVecErg_e;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
