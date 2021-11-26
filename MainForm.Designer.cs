namespace RegexTextbox
{
    partial class MainForm
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
            this.FindButton = new System.Windows.Forms.Button();
            this.ExpressionTextBox = new System.Windows.Forms.TextBox();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton.Location = new System.Drawing.Point(455, 506);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(146, 63);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ExpressionTextBox
            // 
            this.ExpressionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpressionTextBox.Location = new System.Drawing.Point(12, 340);
            this.ExpressionTextBox.Multiline = true;
            this.ExpressionTextBox.Name = "ExpressionTextBox";
            this.ExpressionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ExpressionTextBox.Size = new System.Drawing.Size(1071, 101);
            this.ExpressionTextBox.TabIndex = 2;
            this.ExpressionTextBox.TextChanged += new System.EventHandler(this.ExpressionTextBox_TextChanged);
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(1071, 322);
            this.MainRichTextBox.TabIndex = 0;
            this.MainRichTextBox.Text = "";
            this.MainRichTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainRichTextBox_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 700);
            this.Controls.Add(this.MainRichTextBox);
            this.Controls.Add(this.ExpressionTextBox);
            this.Controls.Add(this.FindButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox ExpressionTextBox;
        private System.Windows.Forms.RichTextBox MainRichTextBox;
    }
}

