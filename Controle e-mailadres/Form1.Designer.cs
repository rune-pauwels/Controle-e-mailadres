namespace Controle_e_mailadres
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
            ControleerButton = new Button();
            EmailAdresTextBox = new TextBox();
            SuspendLayout();
            // 
            // ControleerButton
            // 
            ControleerButton.Location = new Point(295, 12);
            ControleerButton.Name = "ControleerButton";
            ControleerButton.Size = new Size(204, 23);
            ControleerButton.TabIndex = 0;
            ControleerButton.Text = "Controleer Mailadres";
            ControleerButton.UseVisualStyleBackColor = true;
            ControleerButton.Click += ControleerButton_Click;
            // 
            // EmailAdresTextBox
            // 
            EmailAdresTextBox.Location = new Point(12, 12);
            EmailAdresTextBox.Name = "EmailAdresTextBox";
            EmailAdresTextBox.Size = new Size(277, 23);
            EmailAdresTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 54);
            Controls.Add(EmailAdresTextBox);
            Controls.Add(ControleerButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ControleerButton;
        private TextBox EmailAdresTextBox;
    }
}
