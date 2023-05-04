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
            this.nav_customer = new System.Windows.Forms.Button();
            this.nav_rentals = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.nav_return = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(572, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Rental System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nav_cars
            // 
            this.nav_cars.BackColor = System.Drawing.Color.SteelBlue;
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
            // nav_customer
            // 
            this.nav_customer.BackColor = System.Drawing.Color.SteelBlue;
            this.nav_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_customer.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_customer.Location = new System.Drawing.Point(57, 372);
            this.nav_customer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_customer.Name = "nav_customer";
            this.nav_customer.Size = new System.Drawing.Size(328, 135);
            this.nav_customer.TabIndex = 8;
            this.nav_customer.Text = "Customers";
            this.nav_customer.UseVisualStyleBackColor = false;
            // 
            // nav_rentals
            // 
            this.nav_rentals.BackColor = System.Drawing.Color.SteelBlue;
            this.nav_rentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_rentals.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_rentals.Location = new System.Drawing.Point(57, 523);
            this.nav_rentals.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_rentals.Name = "nav_rentals";
            this.nav_rentals.Size = new System.Drawing.Size(328, 135);
            this.nav_rentals.TabIndex = 9;
            this.nav_rentals.Text = "Rentals";
            this.nav_rentals.UseVisualStyleBackColor = false;
            this.nav_rentals.Click += new System.EventHandler(this.nav_rentals_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(1378, 981);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 88);
            this.button5.TabIndex = 43;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // nav_return
            // 
            this.nav_return.BackColor = System.Drawing.Color.SteelBlue;
            this.nav_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_return.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_return.Location = new System.Drawing.Point(57, 674);
            this.nav_return.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_return.Name = "nav_return";
            this.nav_return.Size = new System.Drawing.Size(328, 135);
            this.nav_return.TabIndex = 44;
            this.nav_return.Text = "Return";
            this.nav_return.UseVisualStyleBackColor = false;
            this.nav_return.Click += new System.EventHandler(this.nav_return_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nav_return);
            this.groupBox1.Controls.Add(this.nav_cars);
            this.groupBox1.Controls.Add(this.nav_staffs);
            this.groupBox1.Controls.Add(this.nav_rentals);
            this.groupBox1.Controls.Add(this.nav_customer);
            this.groupBox1.Location = new System.Drawing.Point(45, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 873);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(725, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 500);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(644, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(946, 71);
            this.label2.TabIndex = 47;
            this.label2.Text = "WELLCOME TO CAR RENTAL SYSTEM";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name.Location = new System.Drawing.Point(583, 981);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(102, 45);
            this.lb_name.TabIndex = 48;
            this.lb_name.Text = "Hello:";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_role.Location = new System.Drawing.Point(583, 1032);
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
            this.Controls.Add(this.button5);
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

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nav_cars;
        private System.Windows.Forms.Button nav_staffs;
        private System.Windows.Forms.Button nav_customer;
        private System.Windows.Forms.Button nav_rentals;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button nav_return;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lb_name;
        private Label lb_role;
    }
}