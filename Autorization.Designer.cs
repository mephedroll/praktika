namespace Praktika
{
    partial class Autorization
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
            login_TextBox = new TextBox();
            password_TextBox = new TextBox();
            login_Button = new Button();
            exit_Button = new Button();
            SuspendLayout();
            // 
            // login_TextBox
            // 
            login_TextBox.Location = new Point(191, 93);
            login_TextBox.Name = "login_TextBox";
            login_TextBox.Size = new Size(100, 23);
            login_TextBox.TabIndex = 0;
            // 
            // password_TextBox
            // 
            password_TextBox.Location = new Point(191, 193);
            password_TextBox.Name = "password_TextBox";
            password_TextBox.Size = new Size(100, 23);
            password_TextBox.TabIndex = 1;
            // 
            // login_Button
            // 
            login_Button.Location = new Point(455, 343);
            login_Button.Name = "login_Button";
            login_Button.Size = new Size(75, 23);
            login_Button.TabIndex = 2;
            login_Button.Text = "button1";
            login_Button.UseVisualStyleBackColor = true;
            login_Button.Click += this.login_Button_Click;
            // 
            // exit_Button
            // 
            exit_Button.Location = new Point(667, 343);
            exit_Button.Name = "exit_Button";
            exit_Button.Size = new Size(75, 23);
            exit_Button.TabIndex = 3;
            exit_Button.Text = "button2";
            exit_Button.UseVisualStyleBackColor = true;
            exit_Button.Click += this.exit_Button_Click;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit_Button);
            Controls.Add(login_Button);
            Controls.Add(password_TextBox);
            Controls.Add(login_TextBox);
            Name = "Autorization";
            Text = "Autorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_TextBox;
        private TextBox password_TextBox;
        private Button login_Button;
        private Button exit_Button;
    }
}