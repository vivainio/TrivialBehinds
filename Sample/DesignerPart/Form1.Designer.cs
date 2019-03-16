namespace DesignerPart
{
    partial class Form1
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnLaunchDirect = new System.Windows.Forms.Button();
            this.userControl11 = new DesignerPart.UserControl1();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(21, 12);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "Plus";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(102, 12);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "Minus";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnLaunchDirect
            // 
            this.btnLaunchDirect.Location = new System.Drawing.Point(294, 11);
            this.btnLaunchDirect.Name = "btnLaunchDirect";
            this.btnLaunchDirect.Size = new System.Drawing.Size(75, 23);
            this.btnLaunchDirect.TabIndex = 3;
            this.btnLaunchDirect.Text = "button1";
            this.btnLaunchDirect.UseVisualStyleBackColor = true;
            this.btnLaunchDirect.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(230, 42);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(111, 28);
            this.userControl11.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 93);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnLaunchDirect);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnLaunchDirect;
        private UserControl1 userControl11;
    }
}

