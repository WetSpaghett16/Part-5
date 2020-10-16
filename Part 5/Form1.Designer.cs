namespace Part_5
{
    partial class frmIfStatements
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
            this.txtAGE = new System.Windows.Forms.TextBox();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.lblText2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit2 = new System.Windows.Forms.Button();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAGE
            // 
            this.txtAGE.Location = new System.Drawing.Point(13, 55);
            this.txtAGE.Name = "txtAGE";
            this.txtAGE.Size = new System.Drawing.Size(145, 20);
            this.txtAGE.TabIndex = 0;
            this.txtAGE.TextChanged += new System.EventHandler(this.txtAGE_TextChanged);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.Location = new System.Drawing.Point(12, 30);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(148, 22);
            this.lblText1.TabIndex = 3;
            this.lblText1.Text = "Enter Stage Of Life:";
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult1.Location = new System.Drawing.Point(16, 82);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(0, 21);
            this.lblResult1.TabIndex = 7;
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.Location = new System.Drawing.Point(166, 52);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit1.TabIndex = 8;
            this.btnSubmit1.Text = "Submit";
            this.btnSubmit1.UseVisualStyleBackColor = true;
            this.btnSubmit1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.Location = new System.Drawing.Point(13, 140);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(198, 22);
            this.lblText2.TabIndex = 9;
            this.lblText2.Text = "Enter Hurricane Category:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.Location = new System.Drawing.Point(166, 166);
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit2.TabIndex = 11;
            this.btnSubmit2.Text = "Submit";
            this.btnSubmit2.UseVisualStyleBackColor = true;
            this.btnSubmit2.Click += new System.EventHandler(this.btnSubmit2_Click);
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult2.Location = new System.Drawing.Point(20, 203);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 22);
            this.lblResult2.TabIndex = 12;
            // 
            // frmIfStatements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.btnSubmit2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.btnSubmit1);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.txtAGE);
            this.Name = "frmIfStatements";
            this.Text = "If Statements";
            this.Load += new System.EventHandler(this.frmIfStatements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAGE;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Button btnSubmit1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubmit2;
        private System.Windows.Forms.Label lblResult2;
    }
}

