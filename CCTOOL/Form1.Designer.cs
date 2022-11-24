namespace CCTOOL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.binCheck = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fakeinfoGen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.massGen = new System.Windows.Forms.Button();
            this.uC_genCards1 = new CCTOOL.UC_genCards();
            this.uC_home1 = new CCTOOL.UC_home();
            this.uC_binCheck1 = new CCTOOL.UC_binCheck();
            this.uC_fakeGen1 = new CCTOOL.UC_fakeGen();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.binCheck);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.toolLabel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.fakeinfoGen);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.massGen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 664);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Ivory;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(3, 520);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 10);
            this.panel7.TabIndex = 4;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homeButton.Image = global::CCTOOL.Properties.Resources.home_page_64px;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 423);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(294, 91);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "    Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Ivory;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(3, 407);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 10);
            this.panel6.TabIndex = 3;
            // 
            // binCheck
            // 
            this.binCheck.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.binCheck.FlatAppearance.BorderSize = 0;
            this.binCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binCheck.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.binCheck.Image = global::CCTOOL.Properties.Resources.checked_card_64px;
            this.binCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.binCheck.Location = new System.Drawing.Point(0, 317);
            this.binCheck.Name = "binCheck";
            this.binCheck.Size = new System.Drawing.Size(294, 91);
            this.binCheck.TabIndex = 4;
            this.binCheck.Text = "     BIN CHECK";
            this.binCheck.UseVisualStyleBackColor = true;
            this.binCheck.Click += new System.EventHandler(this.binCheck_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(189, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(108, 10);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 10);
            this.panel4.TabIndex = 2;
            // 
            // toolLabel
            // 
            this.toolLabel.AutoSize = true;
            this.toolLabel.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolLabel.Location = new System.Drawing.Point(87, 25);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(109, 47);
            this.toolLabel.TabIndex = 3;
            this.toolLabel.Text = "Mode";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(5, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 10);
            this.panel3.TabIndex = 2;
            // 
            // fakeinfoGen
            // 
            this.fakeinfoGen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.fakeinfoGen.FlatAppearance.BorderSize = 0;
            this.fakeinfoGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fakeinfoGen.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fakeinfoGen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fakeinfoGen.Image = global::CCTOOL.Properties.Resources.name_tag_64px;
            this.fakeinfoGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fakeinfoGen.Location = new System.Drawing.Point(3, 204);
            this.fakeinfoGen.Name = "fakeinfoGen";
            this.fakeinfoGen.Size = new System.Drawing.Size(294, 91);
            this.fakeinfoGen.TabIndex = 2;
            this.fakeinfoGen.Text = "       Fake Info Gen";
            this.fakeinfoGen.UseVisualStyleBackColor = true;
            this.fakeinfoGen.Click += new System.EventHandler(this.fakeinfoGen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 10);
            this.panel2.TabIndex = 1;
            // 
            // massGen
            // 
            this.massGen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.massGen.FlatAppearance.BorderSize = 0;
            this.massGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.massGen.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.massGen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.massGen.Image = global::CCTOOL.Properties.Resources.card_exchange_64px;
            this.massGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.massGen.Location = new System.Drawing.Point(3, 91);
            this.massGen.Name = "massGen";
            this.massGen.Size = new System.Drawing.Size(294, 91);
            this.massGen.TabIndex = 0;
            this.massGen.Text = "      Mass CC Gen";
            this.massGen.UseVisualStyleBackColor = true;
            this.massGen.Click += new System.EventHandler(this.massGen_Click);
            // 
            // uC_genCards1
            // 
            this.uC_genCards1.BackColor = System.Drawing.Color.SlateGray;
            this.uC_genCards1.Location = new System.Drawing.Point(300, 0);
            this.uC_genCards1.Name = "uC_genCards1";
            this.uC_genCards1.Size = new System.Drawing.Size(958, 664);
            this.uC_genCards1.TabIndex = 1;
            // 
            // uC_home1
            // 
            this.uC_home1.BackColor = System.Drawing.Color.SlateGray;
            this.uC_home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_home1.BackgroundImage")));
            this.uC_home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uC_home1.Location = new System.Drawing.Point(300, 0);
            this.uC_home1.Name = "uC_home1";
            this.uC_home1.Size = new System.Drawing.Size(958, 664);
            this.uC_home1.TabIndex = 2;
            // 
            // uC_binCheck1
            // 
            this.uC_binCheck1.BackColor = System.Drawing.Color.SlateGray;
            this.uC_binCheck1.Location = new System.Drawing.Point(300, 0);
            this.uC_binCheck1.Name = "uC_binCheck1";
            this.uC_binCheck1.Size = new System.Drawing.Size(958, 664);
            this.uC_binCheck1.TabIndex = 4;
            // 
            // uC_fakeGen1
            // 
            this.uC_fakeGen1.BackColor = System.Drawing.Color.SlateGray;
            this.uC_fakeGen1.Location = new System.Drawing.Point(300, 0);
            this.uC_fakeGen1.Name = "uC_fakeGen1";
            this.uC_fakeGen1.Size = new System.Drawing.Size(968, 664);
            this.uC_fakeGen1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uC_home1);
            this.Controls.Add(this.uC_fakeGen1);
            this.Controls.Add(this.uC_genCards1);
            this.Controls.Add(this.uC_binCheck1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCTOOLZ by S3ri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button massGen;
        private Panel panel2;
        private Panel panel3;
        private Button fakeinfoGen;
        private Label toolLabel;
        private Panel panel5;
        private Panel panel4;
        private UC_genCards uC_genCards1;
        private object try2;
        private object try1;
        private UC_home uC_home1;
        private Button binCheck;
        private Panel panel6;
        private UC_binCheck uC_binCheck1;
        private Panel panel7;
        private Button homeButton;
        private UC_fakeGen uC_fakeGen1;
    }
}