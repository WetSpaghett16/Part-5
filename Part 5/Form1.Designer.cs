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
            // frmIfStatements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(430, 450);
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
    }
}

