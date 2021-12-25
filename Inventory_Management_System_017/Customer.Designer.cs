
namespace Inventory_Management_System_017
{
    partial class Customer
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
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.cMobileNo_txt = new System.Windows.Forms.TextBox();
            this.cMobile_no_lbl = new System.Windows.Forms.Label();
            this.cAddress_txt = new System.Windows.Forms.TextBox();
            this.cCustomerName_txt = new System.Windows.Forms.TextBox();
            this.cAddress_lbl = new System.Windows.Forms.Label();
            this.cCustomerName_lbl = new System.Windows.Forms.Label();
            this.lblCustomerRecords = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Helvetica", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerInfo.Location = new System.Drawing.Point(246, 67);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(185, 15);
            this.lblCustomerInfo.TabIndex = 20;
            this.lblCustomerInfo.Text = "CUSTOMER INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.home_btn);
            this.groupBox1.Controls.Add(this.cMobileNo_txt);
            this.groupBox1.Controls.Add(this.cMobile_no_lbl);
            this.groupBox1.Controls.Add(this.cAddress_txt);
            this.groupBox1.Controls.Add(this.cCustomerName_txt);
            this.groupBox1.Controls.Add(this.cAddress_lbl);
            this.groupBox1.Controls.Add(this.cCustomerName_lbl);
            this.groupBox1.Location = new System.Drawing.Point(39, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 183);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEW CUSTOMER";
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(504, 141);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(102, 36);
            this.delete_btn.TabIndex = 17;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(341, 141);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(102, 36);
            this.update_btn.TabIndex = 16;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(174, 141);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(102, 36);
            this.add_btn.TabIndex = 15;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(9, 141);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(102, 36);
            this.home_btn.TabIndex = 14;
            this.home_btn.Text = "HOME";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // cMobileNo_txt
            // 
            this.cMobileNo_txt.Font = new System.Drawing.Font("Helvetica Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMobileNo_txt.Location = new System.Drawing.Point(148, 101);
            this.cMobileNo_txt.Name = "cMobileNo_txt";
            this.cMobileNo_txt.Size = new System.Drawing.Size(458, 23);
            this.cMobileNo_txt.TabIndex = 11;
            // 
            // cMobile_no_lbl
            // 
            this.cMobile_no_lbl.AutoSize = true;
            this.cMobile_no_lbl.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMobile_no_lbl.Location = new System.Drawing.Point(6, 105);
            this.cMobile_no_lbl.Name = "cMobile_no_lbl";
            this.cMobile_no_lbl.Size = new System.Drawing.Size(89, 15);
            this.cMobile_no_lbl.TabIndex = 8;
            this.cMobile_no_lbl.Text = "MOBILE NO.";
            // 
            // cAddress_txt
            // 
            this.cAddress_txt.Font = new System.Drawing.Font("Helvetica Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddress_txt.Location = new System.Drawing.Point(148, 64);
            this.cAddress_txt.Name = "cAddress_txt";
            this.cAddress_txt.Size = new System.Drawing.Size(458, 23);
            this.cAddress_txt.TabIndex = 6;
            // 
            // cCustomerName_txt
            // 
            this.cCustomerName_txt.Font = new System.Drawing.Font("Helvetica Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCustomerName_txt.Location = new System.Drawing.Point(148, 29);
            this.cCustomerName_txt.Name = "cCustomerName_txt";
            this.cCustomerName_txt.Size = new System.Drawing.Size(458, 23);
            this.cCustomerName_txt.TabIndex = 5;
            // 
            // cAddress_lbl
            // 
            this.cAddress_lbl.AutoSize = true;
            this.cAddress_lbl.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddress_lbl.Location = new System.Drawing.Point(6, 68);
            this.cAddress_lbl.Name = "cAddress_lbl";
            this.cAddress_lbl.Size = new System.Drawing.Size(75, 15);
            this.cAddress_lbl.TabIndex = 3;
            this.cAddress_lbl.Text = "ADDRESS";
            // 
            // cCustomerName_lbl
            // 
            this.cCustomerName_lbl.AutoSize = true;
            this.cCustomerName_lbl.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCustomerName_lbl.Location = new System.Drawing.Point(6, 33);
            this.cCustomerName_lbl.Name = "cCustomerName_lbl";
            this.cCustomerName_lbl.Size = new System.Drawing.Size(129, 15);
            this.cCustomerName_lbl.TabIndex = 2;
            this.cCustomerName_lbl.Text = "CUSTOMER NAME";
            // 
            // lblCustomerRecords
            // 
            this.lblCustomerRecords.AutoSize = true;
            this.lblCustomerRecords.Font = new System.Drawing.Font("Helvetica", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerRecords.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerRecords.Location = new System.Drawing.Point(260, 286);
            this.lblCustomerRecords.Name = "lblCustomerRecords";
            this.lblCustomerRecords.Size = new System.Drawing.Size(160, 15);
            this.lblCustomerRecords.TabIndex = 22;
            this.lblCustomerRecords.Text = "CUSTOMER RECORDS";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(39, 313);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(621, 137);
            this.dataGridView.TabIndex = 23;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblCustomerRecords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.TextBox cMobileNo_txt;
        private System.Windows.Forms.Label cMobile_no_lbl;
        private System.Windows.Forms.TextBox cAddress_txt;
        private System.Windows.Forms.TextBox cCustomerName_txt;
        private System.Windows.Forms.Label cAddress_lbl;
        private System.Windows.Forms.Label cCustomerName_lbl;
        private System.Windows.Forms.Label lblCustomerRecords;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
    }
}