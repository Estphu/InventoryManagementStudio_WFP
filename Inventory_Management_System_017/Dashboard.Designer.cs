
namespace Inventory_Management_System_017
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RegistrationInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehouseInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehousesInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrationInterface,
            this.CustomerInterface,
            this.WarehouseInterface,
            this.ProductInterface,
            this.WarehousesInterface,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(139, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegistrationInterface
            // 
            this.RegistrationInterface.BackColor = System.Drawing.Color.Goldenrod;
            this.RegistrationInterface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistrationInterface.Name = "RegistrationInterface";
            this.RegistrationInterface.Size = new System.Drawing.Size(88, 20);
            this.RegistrationInterface.Text = "Manage User";
            this.RegistrationInterface.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // CustomerInterface
            // 
            this.CustomerInterface.BackColor = System.Drawing.Color.Goldenrod;
            this.CustomerInterface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerInterface.Name = "CustomerInterface";
            this.CustomerInterface.Size = new System.Drawing.Size(71, 20);
            this.CustomerInterface.Text = "Customer";
            this.CustomerInterface.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // WarehouseInterface
            // 
            this.WarehouseInterface.BackColor = System.Drawing.Color.Goldenrod;
            this.WarehouseInterface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WarehouseInterface.Name = "WarehouseInterface";
            this.WarehouseInterface.Size = new System.Drawing.Size(67, 20);
            this.WarehouseInterface.Text = "Category";
            this.WarehouseInterface.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // ProductInterface
            // 
            this.ProductInterface.BackColor = System.Drawing.Color.Goldenrod;
            this.ProductInterface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductInterface.Name = "ProductInterface";
            this.ProductInterface.Size = new System.Drawing.Size(61, 20);
            this.ProductInterface.Text = "Product";
            this.ProductInterface.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // WarehousesInterface
            // 
            this.WarehousesInterface.BackColor = System.Drawing.Color.Goldenrod;
            this.WarehousesInterface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WarehousesInterface.Name = "WarehousesInterface";
            this.WarehousesInterface.Size = new System.Drawing.Size(83, 20);
            this.WarehousesInterface.Text = "Warehouses";
            this.WarehousesInterface.Click += new System.EventHandler(this.WarehousesInterface_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Goldenrod;
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(38, 20);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(107, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 51);
            this.panel1.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(707, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RegistrationInterface;
        private System.Windows.Forms.ToolStripMenuItem CustomerInterface;
        private System.Windows.Forms.ToolStripMenuItem WarehouseInterface;
        private System.Windows.Forms.ToolStripMenuItem ProductInterface;
        private System.Windows.Forms.ToolStripMenuItem WarehousesInterface;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem exit;
    }
}