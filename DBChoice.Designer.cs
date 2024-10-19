namespace Praktika
{
    partial class DBChoice
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pccompany_Button = new Button();
            secondaryMaterial_Button = new Button();
            Ships_Button = new Button();
            airport_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(111, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(383, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(141, 273);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(416, 262);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pccompany_Button
            // 
            pccompany_Button.Location = new Point(150, 165);
            pccompany_Button.Name = "pccompany_Button";
            pccompany_Button.Size = new Size(75, 23);
            pccompany_Button.TabIndex = 4;
            pccompany_Button.Text = "button1";
            pccompany_Button.UseVisualStyleBackColor = true;
            pccompany_Button.Click += pccompany_Button_Click;
            // 
            // secondaryMaterial_Button
            // 
            secondaryMaterial_Button.Location = new Point(443, 156);
            secondaryMaterial_Button.Name = "secondaryMaterial_Button";
            secondaryMaterial_Button.Size = new Size(75, 23);
            secondaryMaterial_Button.TabIndex = 5;
            secondaryMaterial_Button.Text = "button1";
            secondaryMaterial_Button.UseVisualStyleBackColor = true;
            secondaryMaterial_Button.Click += secondaryMaterial_Button_Click;
            // 
            // Ships_Button
            // 
            Ships_Button.Location = new Point(177, 363);
            Ships_Button.Name = "Ships_Button";
            Ships_Button.Size = new Size(75, 23);
            Ships_Button.TabIndex = 6;
            Ships_Button.Text = "button2";
            Ships_Button.UseVisualStyleBackColor = true;
            Ships_Button.Click += Ships_Button_Click;
            // 
            // airport_Button
            // 
            airport_Button.Location = new Point(455, 365);
            airport_Button.Name = "airport_Button";
            airport_Button.Size = new Size(75, 23);
            airport_Button.TabIndex = 7;
            airport_Button.Text = "button3";
            airport_Button.UseVisualStyleBackColor = true;
            airport_Button.Click += airport_Button_Click;
            // 
            // DBChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(airport_Button);
            Controls.Add(Ships_Button);
            Controls.Add(secondaryMaterial_Button);
            Controls.Add(pccompany_Button);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "DBChoice";
            Text = "DBChoice";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button pccompany_Button;
        private Button secondaryMaterial_Button;
        private Button Ships_Button;
        private Button airport_Button;
    }
}