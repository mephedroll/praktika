namespace Praktika
{
    partial class Main
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
            PCCompany_button = new Button();
            Airport_button = new Button();
            SecondaryRow_button = new Button();
            Ships_button = new Button();
            SuspendLayout();
            // 
            // PCCompany_button
            // 
            PCCompany_button.Location = new Point(172, 343);
            PCCompany_button.Name = "PCCompany_button";
            PCCompany_button.Size = new Size(75, 23);
            PCCompany_button.TabIndex = 0;
            PCCompany_button.Text = "button1";
            PCCompany_button.UseVisualStyleBackColor = true;
            PCCompany_button.Click += PCCompany_button_Click;
            // 
            // Airport_button
            // 
            Airport_button.Location = new Point(415, 345);
            Airport_button.Name = "Airport_button";
            Airport_button.Size = new Size(75, 23);
            Airport_button.TabIndex = 1;
            Airport_button.Text = "button2";
            Airport_button.UseVisualStyleBackColor = true;
            Airport_button.Click += Airport_button_Click;
            // 
            // SecondaryRow_button
            // 
            SecondaryRow_button.Location = new Point(179, 121);
            SecondaryRow_button.Name = "SecondaryRow_button";
            SecondaryRow_button.Size = new Size(75, 23);
            SecondaryRow_button.TabIndex = 2;
            SecondaryRow_button.Text = "button3";
            SecondaryRow_button.UseVisualStyleBackColor = true;
            SecondaryRow_button.Click += SecondaryRow_button_Click;
            // 
            // Ships_button
            // 
            Ships_button.Location = new Point(435, 118);
            Ships_button.Name = "Ships_button";
            Ships_button.Size = new Size(75, 23);
            Ships_button.TabIndex = 3;
            Ships_button.Text = "button4";
            Ships_button.UseVisualStyleBackColor = true;
            Ships_button.Click += Ships_button_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ships_button);
            Controls.Add(SecondaryRow_button);
            Controls.Add(Airport_button);
            Controls.Add(PCCompany_button);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button PCCompany_button;
        private Button Airport_button;
        private Button SecondaryRow_button;
        private Button Ships_button;
    }
}
