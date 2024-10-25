namespace Praktika
{
    partial class PCCompany
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCCompany));
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            sqlConnectionBindingSource = new BindingSource(components);
            add_Button = new Button();
            update_Button = new Button();
            delete_Button = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 321);
            dataGridView1.TabIndex = 1;
            // 
            // sqlConnectionBindingSource
            // 
            sqlConnectionBindingSource.DataSource = typeof(System.Data.SqlClient.SqlConnection);
            // 
            // add_Button
            // 
            add_Button.Location = new Point(697, 402);
            add_Button.Name = "add_Button";
            add_Button.Size = new Size(91, 36);
            add_Button.TabIndex = 2;
            add_Button.Text = "INSERT";
            add_Button.UseVisualStyleBackColor = true;
            add_Button.Click += add_Button_Click;
            // 
            // update_Button
            // 
            update_Button.Location = new Point(566, 402);
            update_Button.Name = "update_Button";
            update_Button.Size = new Size(90, 36);
            update_Button.TabIndex = 3;
            update_Button.Text = "UPDATE";
            update_Button.UseVisualStyleBackColor = true;
            update_Button.Click += update_Button_Click;
            // 
            // delete_Button
            // 
            delete_Button.Location = new Point(434, 402);
            delete_Button.Name = "delete_Button";
            delete_Button.Size = new Size(88, 36);
            delete_Button.TabIndex = 4;
            delete_Button.Text = "DELETE";
            delete_Button.UseVisualStyleBackColor = true;
            delete_Button.Click += delete_Button_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(53, 22);
            toolStripButton1.Text = "Product";
            toolStripButton1.TextImageRelation = TextImageRelation.TextAboveImage;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(26, 22);
            toolStripButton2.Text = "PC";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(48, 22);
            toolStripButton3.Text = "Laptop";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(46, 22);
            toolStripButton4.Text = "Printer";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // PCCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(delete_Button);
            Controls.Add(update_Button);
            Controls.Add(add_Button);
            Controls.Add(dataGridView1);
            Name = "PCCompany";
            Text = "PCCompany";
            Load += PCCompany_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private BindingSource sqlConnectionBindingSource;
        private Button add_Button;
        private Button update_Button;
        private Button delete_Button;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
    }
}