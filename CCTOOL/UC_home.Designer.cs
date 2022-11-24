namespace CCTOOL
{
    partial class UC_home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(585, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "v1.0.5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "©SofTEK";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(906, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "@S3ri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeLabel.Location = new System.Drawing.Point(354, 196);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(246, 86);
            this.homeLabel.TabIndex = 2;
            this.homeLabel.Text = "CC-TOOLZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "- Patch v1.0.4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "- Implemented Luhn\'s Algorithm on Mass Gen for accuracy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "- Patch v1.0.5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(51, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 33);
            this.label7.TabIndex = 9;
            this.label7.Text = "- Bug fixed";
            // 
            // UC_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = global::CCTOOL.Properties.Resources.pixel_cat_96px;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UC_home";
            this.Size = new System.Drawing.Size(958, 664);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label homeLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
