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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_display_cars = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1894, 143);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(716, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Rental System";
            // 
            // nav_cars
            // 
            this.nav_cars.BackColor = System.Drawing.Color.Firebrick;
            this.nav_cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_cars.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_cars.Location = new System.Drawing.Point(91, 223);
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
            this.nav_staffs.BackColor = System.Drawing.Color.Firebrick;
            this.nav_staffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_staffs.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_staffs.Location = new System.Drawing.Point(431, 223);
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
            this.nav_customer.BackColor = System.Drawing.Color.Firebrick;
            this.nav_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_customer.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_customer.Location = new System.Drawing.Point(771, 223);
            this.nav_customer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_customer.Name = "nav_customer";
            this.nav_customer.Size = new System.Drawing.Size(328, 135);
            this.nav_customer.TabIndex = 8;
            this.nav_customer.Text = "Customers";
            this.nav_customer.UseVisualStyleBackColor = false;
            // 
            // nav_rentals
            // 
            this.nav_rentals.BackColor = System.Drawing.Color.Firebrick;
            this.nav_rentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_rentals.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_rentals.Location = new System.Drawing.Point(1111, 223);
            this.nav_rentals.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_rentals.Name = "nav_rentals";
            this.nav_rentals.Size = new System.Drawing.Size(328, 135);
            this.nav_rentals.TabIndex = 9;
            this.nav_rentals.Text = "Rentals";
            this.nav_rentals.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(1563, 1157);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 88);
            this.button5.TabIndex = 43;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // nav_return
            // 
            this.nav_return.BackColor = System.Drawing.Color.Firebrick;
            this.nav_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nav_return.ForeColor = System.Drawing.SystemColors.Window;
            this.nav_return.Location = new System.Drawing.Point(1449, 223);
            this.nav_return.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nav_return.Name = "nav_return";
            this.nav_return.Size = new System.Drawing.Size(328, 135);
            this.nav_return.TabIndex = 44;
            this.nav_return.Text = "Return";
            this.nav_return.UseVisualStyleBackColor = false;
            this.nav_return.Click += new System.EventHandler(this.nav_return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 700);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1053, 573);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_display_cars
            // 
            this.btn_display_cars.BackColor = System.Drawing.Color.Green;
            this.btn_display_cars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_display_cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_display_cars.ForeColor = System.Drawing.Color.White;
            this.btn_display_cars.Image = ((System.Drawing.Image)(resources.GetObject("btn_display_cars.Image")));
            this.btn_display_cars.Location = new System.Drawing.Point(685, 428);
            this.btn_display_cars.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_display_cars.Name = "btn_display_cars";
            this.btn_display_cars.Size = new System.Drawing.Size(492, 234);
            this.btn_display_cars.TabIndex = 45;
            this.btn_display_cars.Text = "Display cars";
            this.btn_display_cars.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1894, 1318);
            this.Controls.Add(this.btn_display_cars);
            this.Controls.Add(this.nav_return);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.nav_rentals);
            this.Controls.Add(this.nav_customer);
            this.Controls.Add(this.nav_staffs);
            this.Controls.Add(this.nav_cars);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Main";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_display_cars;
    }
}