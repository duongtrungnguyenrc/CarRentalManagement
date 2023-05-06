namespace GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nav_cars = new System.Windows.Forms.Button();
            this.nav_staffs = new System.Windows.Forms.Button();
            this.nav_new_contract = new System.Windows.Forms.Button();
            this.nav_ManageContracts = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.nav_setting = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            this.FormClosed += Main_FormClosed;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1681, 143);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(577, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Rental System";
            // 
            // nav_cars
            // 
            this.nav_cars.BackColor = System.Drawing.Color.SteelBlue;
            this.nav_cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_cars.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_cars.Location = new System.Drawing.Point(57, 70);
            this.nav_cars.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_cars.Name = "nav_cars";
            this.nav_cars.Size = new System.Drawing.Size(328, 135);
            this.nav_cars.TabIndex = 2;
            this.nav_cars.Text = "Cars";
            this.nav_cars.UseVisualStyleBackColor = false;
            this.nav_cars.Click += new System.EventHandler(this.nav_cars_Click);
            // 
            // nav_staffs
            // 
            this.nav_staffs.BackColor = System.Drawing.Color.SteelBlue;
            this.nav_staffs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_staffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_staffs.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_staffs.Location = new System.Drawing.Point(57, 221);
            this.nav_staffs.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_staffs.Name = "nav_staffs";
            this.nav_staffs.Size = new System.Drawing.Size(328, 135);
            this.nav_staffs.TabIndex = 7;
            this.nav_staffs.Text = "Staffs";
            this.nav_staffs.UseVisualStyleBackColor = false;
            this.nav_staffs.Click += new System.EventHandler(this.nav_staffs_Click);
            // 
            // nav_new_contract
            // 
            this.nav_new_contract.BackColor = System.Drawing.Color.SteelBlue;
            this.nav_new_contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_new_contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_new_contract.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_new_contract.Location = new System.Drawing.Point(57, 372);
            this.nav_new_contract.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_new_contract.Name = "nav_new_contract";
            this.nav_new_contract.Size = new System.Drawing.Size(328, 135);
            this.nav_new_contract.TabIndex = 8;
            this.nav_new_contract.Text = "New contract";
            this.nav_new_contract.UseVisualStyleBackColor = false;
            this.nav_new_contract.Click += new System.EventHandler(this.nav_new_contract_Click);
            // 
            // nav_ManageContracts
            // 
            this.nav_ManageContracts.BackColor = System.Drawing.Color.SteelBlue;
            this.nav_ManageContracts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_ManageContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_ManageContracts.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_ManageContracts.Location = new System.Drawing.Point(57, 523);
            this.nav_ManageContracts.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_ManageContracts.Name = "nav_ManageContracts";
            this.nav_ManageContracts.Size = new System.Drawing.Size(328, 135);
            this.nav_ManageContracts.TabIndex = 9;
            this.nav_ManageContracts.Text = "Contracts";
            this.nav_ManageContracts.UseVisualStyleBackColor = false;
            this.nav_ManageContracts.Click += new System.EventHandler(this.nav_ManageContracts_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.IndianRed;
            this.btn_log_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_log_out.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_log_out.Location = new System.Drawing.Point(1378, 981);
            this.btn_log_out.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(225, 88);
            this.btn_log_out.TabIndex = 43;
            this.btn_log_out.Text = "Logout";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // nav_setting
            // 
            this.nav_setting.BackColor = System.Drawing.Color.SteelBlue;
            this.nav_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_setting.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_setting.Location = new System.Drawing.Point(57, 674);
            this.nav_setting.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_setting.Name = "nav_setting";
            this.nav_setting.Size = new System.Drawing.Size(328, 135);
            this.nav_setting.TabIndex = 44;
            this.nav_setting.Text = "Settings";
            this.nav_setting.UseVisualStyleBackColor = false;
            this.nav_setting.Click += new System.EventHandler(this.nav_setting_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nav_setting);
            this.groupBox1.Controls.Add(this.nav_cars);
            this.groupBox1.Controls.Add(this.nav_staffs);
            this.groupBox1.Controls.Add(this.nav_ManageContracts);
            this.groupBox1.Controls.Add(this.nav_new_contract);
            this.groupBox1.Location = new System.Drawing.Point(45, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 884);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(698, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 500);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(615, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(946, 71);
            this.label2.TabIndex = 47;
            this.label2.Text = "WELLCOME TO CAR RENTAL SYSTEM";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name.Location = new System.Drawing.Point(587, 966);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(102, 45);
            this.lb_name.TabIndex = 48;
            this.lb_name.Text = "Hello:";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_role.Location = new System.Drawing.Point(587, 1009);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(102, 45);
            this.lb_role.TabIndex = 49;
            this.lb_role.Text = "Hello:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1681, 1131);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Main";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nav_cars;
        private System.Windows.Forms.Button nav_staffs;
        private System.Windows.Forms.Button nav_new_contract;
        private System.Windows.Forms.Button nav_ManageContracts;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button nav_setting;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lb_name;
        private Label lb_role;
    }
}