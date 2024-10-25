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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            PCCompany_button = new Button();
            Airport_button = new Button();
            SecondaryRow_button = new Button();
            Ships_button = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // PCCompany_button
            // 
            PCCompany_button.Location = new Point(129, 361);
            PCCompany_button.Name = "PCCompany_button";
            PCCompany_button.Size = new Size(125, 44);
            PCCompany_button.TabIndex = 0;
            PCCompany_button.Text = "PCCompany";
            PCCompany_button.UseVisualStyleBackColor = true;
            PCCompany_button.Click += PCCompany_button_Click;
            // 
            // Airport_button
            // 
            Airport_button.Location = new Point(591, 361);
            Airport_button.Name = "Airport_button";
            Airport_button.Size = new Size(124, 44);
            Airport_button.TabIndex = 1;
            Airport_button.Text = "Airport";
            Airport_button.UseVisualStyleBackColor = true;
            Airport_button.Click += Airport_button_Click;
            // 
            // SecondaryRow_button
            // 
            SecondaryRow_button.Location = new Point(91, 153);
            SecondaryRow_button.Name = "SecondaryRow_button";
            SecondaryRow_button.Size = new Size(201, 54);
            SecondaryRow_button.TabIndex = 2;
            SecondaryRow_button.Text = "SecondaryRowMaterialsCompany";
            SecondaryRow_button.UseVisualStyleBackColor = true;
            SecondaryRow_button.Click += SecondaryRow_button_Click;
            // 
            // Ships_button
            // 
            Ships_button.Location = new Point(591, 163);
            Ships_button.Name = "Ships_button";
            Ships_button.Size = new Size(120, 44);
            Ships_button.TabIndex = 3;
            Ships_button.Text = "Ships";
            Ships_button.UseVisualStyleBackColor = true;
            Ships_button.Click += Ships_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 244);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(76, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(541, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(219, 118);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(541, 244);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(219, 111);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Ships_button);
            Controls.Add(SecondaryRow_button);
            Controls.Add(Airport_button);
            Controls.Add(PCCompany_button);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button PCCompany_button;
        private Button Airport_button;
        private Button SecondaryRow_button;
        private Button Ships_button;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
