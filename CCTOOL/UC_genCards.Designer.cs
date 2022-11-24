namespace CCTOOL
{
    partial class UC_genCards
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
            this.genAmount = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.cvvLabel = new System.Windows.Forms.Label();
            this.cvvInput = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthCBox = new System.Windows.Forms.ComboBox();
            this.yearCBox = new System.Windows.Forms.ComboBox();
            this.genButton = new System.Windows.Forms.Button();
            this.outputCC = new System.Windows.Forms.RichTextBox();
            this.inputCC = new System.Windows.Forms.RichTextBox();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genAmount
            // 
            this.genAmount.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genAmount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.genAmount.Location = new System.Drawing.Point(153, 3);
            this.genAmount.Name = "genAmount";
            this.genAmount.PlaceholderText = "Amount";
            this.genAmount.Size = new System.Drawing.Size(150, 31);
            this.genAmount.TabIndex = 0;
            this.genAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.genAmount.TextChanged += new System.EventHandler(this.genAmount_TextChanged);
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyButton.Location = new System.Drawing.Point(594, 559);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(169, 43);
            this.copyButton.TabIndex = 1;
            this.copyButton.Text = "Copy All";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(264, 557);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 45);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cvvLabel
            // 
            this.cvvLabel.AutoSize = true;
            this.cvvLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cvvLabel.Location = new System.Drawing.Point(387, 270);
            this.cvvLabel.Name = "cvvLabel";
            this.cvvLabel.Size = new System.Drawing.Size(46, 23);
            this.cvvLabel.TabIndex = 2;
            this.cvvLabel.Text = "CVV";
            // 
            // cvvInput
            // 
            this.cvvInput.Location = new System.Drawing.Point(372, 298);
            this.cvvInput.Name = "cvvInput";
            this.cvvInput.PlaceholderText = "Random";
            this.cvvInput.Size = new System.Drawing.Size(79, 31);
            this.cvvInput.TabIndex = 3;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthLabel.Location = new System.Drawing.Point(378, 185);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(63, 23);
            this.monthLabel.TabIndex = 4;
            this.monthLabel.Text = "Month";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(386, 97);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(48, 23);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year";
            // 
            // monthCBox
            // 
            this.monthCBox.FormattingEnabled = true;
            this.monthCBox.Location = new System.Drawing.Point(369, 213);
            this.monthCBox.Name = "monthCBox";
            this.monthCBox.Size = new System.Drawing.Size(81, 33);
            this.monthCBox.TabIndex = 6;
            // 
            // yearCBox
            // 
            this.yearCBox.FormattingEnabled = true;
            this.yearCBox.Location = new System.Drawing.Point(369, 125);
            this.yearCBox.Name = "yearCBox";
            this.yearCBox.Size = new System.Drawing.Size(81, 33);
            this.yearCBox.TabIndex = 7;
            // 
            // genButton
            // 
            this.genButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genButton.Location = new System.Drawing.Point(89, 559);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(169, 43);
            this.genButton.TabIndex = 8;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // outputCC
            // 
            this.outputCC.Location = new System.Drawing.Point(463, 44);
            this.outputCC.Name = "outputCC";
            this.outputCC.ReadOnly = true;
            this.outputCC.Size = new System.Drawing.Size(412, 509);
            this.outputCC.TabIndex = 9;
            this.outputCC.Text = "";
            // 
            // inputCC
            // 
            this.inputCC.Location = new System.Drawing.Point(89, 44);
            this.inputCC.Name = "inputCC";
            this.inputCC.Size = new System.Drawing.Size(274, 509);
            this.inputCC.TabIndex = 10;
            this.inputCC.Text = "";
            // 
            // shuffleButton
            // 
            this.shuffleButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shuffleButton.Location = new System.Drawing.Point(463, 558);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(99, 45);
            this.shuffleButton.TabIndex = 12;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importButton.Location = new System.Drawing.Point(89, 608);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(169, 43);
            this.importButton.TabIndex = 13;
            this.importButton.Text = "Import Combo";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // UC_genCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.genAmount);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.cvvLabel);
            this.Controls.Add(this.cvvInput);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthCBox);
            this.Controls.Add(this.yearCBox);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.outputCC);
            this.Controls.Add(this.inputCC);
            this.Controls.Add(this.clearButton);
            this.Name = "UC_genCards";
            this.Size = new System.Drawing.Size(958, 664);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox genAmount;
        private Button copyButton;
        private Button clearButton;
        private Label cvvLabel;
        private TextBox cvvInput;
        private Label monthLabel;
        private Label yearLabel;
        private ComboBox monthCBox;
        private ComboBox yearCBox;
        private Button genButton;
        private RichTextBox outputCC;
        private RichTextBox inputCC;
        private Button shuffleButton;
        private Button importButton;
    }
}
