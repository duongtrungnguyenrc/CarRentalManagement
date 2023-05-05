namespace GUI
{
    partial class ManagerCars
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_hour_rent = new System.Windows.Forms.Label();
            this.lb_num_of_seats = new System.Windows.Forms.Label();
            this.lb_km = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_num_of_seats = new System.Windows.Forms.TextBox();
            this.txt_hour_rent = new System.Windows.Forms.TextBox();
            this.txt_day_rent = new System.Windows.Forms.TextBox();
            this.img_car = new System.Windows.Forms.PictureBox();
            this.btn_browser_image = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_data_form = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_car_price = new System.Windows.Forms.TextBox();
            this.cb_engine = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_car_year = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_deposit_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_cars = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentByTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentByDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_export = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_car)).BeginInit();
            this.gb_data_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_cars)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(2305, 143);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(955, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cars Manage";
            // 
            // txt_name
            // 
            this.txt_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_name.Location = new System.Drawing.Point(250, 60);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(1412, 39);
            this.txt_name.TabIndex = 27;
            // 
            // lb_hour_rent
            // 
            this.lb_hour_rent.AutoSize = true;
            this.lb_hour_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_hour_rent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_hour_rent.Location = new System.Drawing.Point(599, 292);
            this.lb_hour_rent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_hour_rent.Name = "lb_hour_rent";
            this.lb_hour_rent.Size = new System.Drawing.Size(159, 31);
            this.lb_hour_rent.TabIndex = 24;
            this.lb_hour_rent.Text = "Hourly price";
            // 
            // lb_num_of_seats
            // 
            this.lb_num_of_seats.AutoSize = true;
            this.lb_num_of_seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_num_of_seats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_num_of_seats.Location = new System.Drawing.Point(597, 219);
            this.lb_num_of_seats.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_num_of_seats.Name = "lb_num_of_seats";
            this.lb_num_of_seats.Size = new System.Drawing.Size(174, 31);
            this.lb_num_of_seats.TabIndex = 23;
            this.lb_num_of_seats.Text = "Num of seats";
            // 
            // lb_km
            // 
            this.lb_km.AutoSize = true;
            this.lb_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_km.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_km.Location = new System.Drawing.Point(58, 296);
            this.lb_km.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_km.Name = "lb_km";
            this.lb_km.Size = new System.Drawing.Size(166, 31);
            this.lb_km.TabIndex = 22;
            this.lb_km.Text = "Km traveled:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(58, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "generation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(58, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1147, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 31);
            this.label9.TabIndex = 34;
            this.label9.Text = "Daily price";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(2050, 190);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(165, 66);
            this.btn_delete.TabIndex = 41;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_num_of_seats
            // 
            this.txt_num_of_seats.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_num_of_seats.Location = new System.Drawing.Point(789, 217);
            this.txt_num_of_seats.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_num_of_seats.Name = "txt_num_of_seats";
            this.txt_num_of_seats.Size = new System.Drawing.Size(313, 39);
            this.txt_num_of_seats.TabIndex = 48;
            // 
            // txt_hour_rent
            // 
            this.txt_hour_rent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_hour_rent.Location = new System.Drawing.Point(786, 286);
            this.txt_hour_rent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_hour_rent.Name = "txt_hour_rent";
            this.txt_hour_rent.Size = new System.Drawing.Size(316, 39);
            this.txt_hour_rent.TabIndex = 49;
            // 
            // txt_day_rent
            // 
            this.txt_day_rent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_day_rent.Location = new System.Drawing.Point(1355, 133);
            this.txt_day_rent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_day_rent.Name = "txt_day_rent";
            this.txt_day_rent.Size = new System.Drawing.Size(309, 39);
            this.txt_day_rent.TabIndex = 50;
            // 
            // img_car
            // 
            this.img_car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_car.Location = new System.Drawing.Point(1722, 85);
            this.img_car.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.img_car.Name = "img_car";
            this.img_car.Size = new System.Drawing.Size(280, 245);
            this.img_car.TabIndex = 51;
            this.img_car.TabStop = false;
            // 
            // btn_browser_image
            // 
            this.btn_browser_image.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_browser_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_browser_image.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_browser_image.Location = new System.Drawing.Point(1793, 346);
            this.btn_browser_image.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_browser_image.Name = "btn_browser_image";
            this.btn_browser_image.Size = new System.Drawing.Size(142, 65);
            this.btn_browser_image.TabIndex = 52;
            this.btn_browser_image.Text = "Browse";
            this.btn_browser_image.UseVisualStyleBackColor = false;
            this.btn_browser_image.Click += new System.EventHandler(this.btn_browser_image_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(1722, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 37);
            this.label12.TabIndex = 53;
            this.label12.Text = "Image";
            // 
            // gb_data_form
            // 
            this.gb_data_form.Controls.Add(this.btn_export);
            this.gb_data_form.Controls.Add(this.txt_id);
            this.gb_data_form.Controls.Add(this.btn_edit);
            this.gb_data_form.Controls.Add(this.txt_km);
            this.gb_data_form.Controls.Add(this.txt_car_price);
            this.gb_data_form.Controls.Add(this.cb_engine);
            this.gb_data_form.Controls.Add(this.label7);
            this.gb_data_form.Controls.Add(this.btn_save);
            this.gb_data_form.Controls.Add(this.btn_exit);
            this.gb_data_form.Controls.Add(this.label3);
            this.gb_data_form.Controls.Add(this.btn_delete);
            this.gb_data_form.Controls.Add(this.txt_car_year);
            this.gb_data_form.Controls.Add(this.label6);
            this.gb_data_form.Controls.Add(this.txt_deposit_price);
            this.gb_data_form.Controls.Add(this.label2);
            this.gb_data_form.Controls.Add(this.label12);
            this.gb_data_form.Controls.Add(this.btn_browser_image);
            this.gb_data_form.Controls.Add(this.img_car);
            this.gb_data_form.Controls.Add(this.txt_day_rent);
            this.gb_data_form.Controls.Add(this.txt_hour_rent);
            this.gb_data_form.Controls.Add(this.txt_num_of_seats);
            this.gb_data_form.Controls.Add(this.label9);
            this.gb_data_form.Controls.Add(this.txt_name);
            this.gb_data_form.Controls.Add(this.lb_hour_rent);
            this.gb_data_form.Controls.Add(this.lb_num_of_seats);
            this.gb_data_form.Controls.Add(this.lb_km);
            this.gb_data_form.Controls.Add(this.label5);
            this.gb_data_form.Controls.Add(this.label4);
            this.gb_data_form.Location = new System.Drawing.Point(28, 174);
            this.gb_data_form.Name = "gb_data_form";
            this.gb_data_form.Size = new System.Drawing.Size(2246, 422);
            this.gb_data_form.TabIndex = 54;
            this.gb_data_form.TabStop = false;
            this.gb_data_form.Text = "Data form";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_id.Location = new System.Drawing.Point(1273, 288);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(391, 39);
            this.txt_id.TabIndex = 70;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_edit.Enabled = false;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(2050, 112);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(165, 69);
            this.btn_edit.TabIndex = 69;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(251, 288);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(311, 39);
            this.txt_km.TabIndex = 68;
            // 
            // txt_car_price
            // 
            this.txt_car_price.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_car_price.Location = new System.Drawing.Point(789, 142);
            this.txt_car_price.Name = "txt_car_price";
            this.txt_car_price.Size = new System.Drawing.Size(311, 39);
            this.txt_car_price.TabIndex = 67;
            // 
            // cb_engine
            // 
            this.cb_engine.FormattingEnabled = true;
            this.cb_engine.Items.AddRange(new object[] {
            "gasoline",
            "diesel",
            "electricity",
            "hybrid"});
            this.cb_engine.Location = new System.Drawing.Point(251, 210);
            this.cb_engine.Name = "cb_engine";
            this.cb_engine.Size = new System.Drawing.Size(310, 40);
            this.cb_engine.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(599, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 31);
            this.label7.TabIndex = 65;
            this.label7.Text = "Car price";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(2050, 37);
            this.btn_save.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(165, 69);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(2050, 264);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(165, 66);
            this.btn_exit.TabIndex = 42;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(56, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 63;
            this.label3.Text = "Engine:";
            // 
            // txt_car_year
            // 
            this.txt_car_year.Location = new System.Drawing.Point(250, 138);
            this.txt_car_year.Name = "txt_car_year";
            this.txt_car_year.Size = new System.Drawing.Size(311, 39);
            this.txt_car_year.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1149, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 31);
            this.label6.TabIndex = 61;
            this.label6.Text = "Deposit price";
            // 
            // txt_deposit_price
            // 
            this.txt_deposit_price.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_deposit_price.Location = new System.Drawing.Point(1353, 211);
            this.txt_deposit_price.Name = "txt_deposit_price";
            this.txt_deposit_price.Size = new System.Drawing.Size(309, 39);
            this.txt_deposit_price.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1147, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 59;
            this.label2.Text = "ID";
            // 
            // data_cars
            // 
            this.data_cars.ColumnHeadersHeight = 46;
            this.data_cars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.id,
            this.name,
            this.engineType,
            this.year,
            this.price,
            this.numberOfKm,
            this.rentByTime,
            this.RentByDate,
            this.depositPrice,
            this.numberOfSeats});
            this.data_cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_cars.Location = new System.Drawing.Point(28, 622);
            this.data_cars.MultiSelect = false;
            this.data_cars.Name = "data_cars";
            this.data_cars.RowHeadersWidth = 82;
            this.data_cars.RowTemplate.Height = 41;
            this.data_cars.Size = new System.Drawing.Size(2246, 606);
            this.data_cars.TabIndex = 55;
            this.data_cars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_cars_CellContentClick);
            // 
            // image
            // 
            this.image.HeaderText = "Image";
            this.image.MinimumWidth = 10;
            this.image.Name = "image";
            this.image.Width = 200;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.Width = 200;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // engineType
            // 
            this.engineType.HeaderText = "Engine type";
            this.engineType.MinimumWidth = 10;
            this.engineType.Name = "engineType";
            this.engineType.Width = 200;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.MinimumWidth = 10;
            this.year.Name = "year";
            this.year.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 10;
            this.price.Name = "price";
            this.price.Width = 200;
            // 
            // numberOfKm
            // 
            this.numberOfKm.HeaderText = "Km traveled";
            this.numberOfKm.MinimumWidth = 10;
            this.numberOfKm.Name = "numberOfKm";
            this.numberOfKm.Width = 200;
            // 
            // rentByTime
            // 
            this.rentByTime.HeaderText = "Houry price";
            this.rentByTime.MinimumWidth = 10;
            this.rentByTime.Name = "rentByTime";
            this.rentByTime.Width = 200;
            // 
            // RentByDate
            // 
            this.RentByDate.HeaderText = "Daily price";
            this.RentByDate.MinimumWidth = 10;
            this.RentByDate.Name = "RentByDate";
            this.RentByDate.Width = 200;
            // 
            // depositPrice
            // 
            this.depositPrice.HeaderText = "Deposit price";
            this.depositPrice.MinimumWidth = 10;
            this.depositPrice.Name = "depositPrice";
            this.depositPrice.Width = 200;
            // 
            // numberOfSeats
            // 
            this.numberOfSeats.HeaderText = "Number of seats";
            this.numberOfSeats.MinimumWidth = 10;
            this.numberOfSeats.Name = "numberOfSeats";
            this.numberOfSeats.Width = 200;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_export.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_export.Location = new System.Drawing.Point(2050, 336);
            this.btn_export.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(165, 66);
            this.btn_export.TabIndex = 71;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ManagerCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2305, 1253);
            this.Controls.Add(this.data_cars);
            this.Controls.Add(this.gb_data_form);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ManagerCars";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ManagerCars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_car)).EndInit();
            this.gb_data_form.ResumeLayout(false);
            this.gb_data_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_cars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_hour_rent;
        private System.Windows.Forms.Label lb_num_of_seats;
        private System.Windows.Forms.Label lb_km;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_num_of_seats;
        private System.Windows.Forms.TextBox txt_hour_rent;
        private System.Windows.Forms.TextBox txt_day_rent;
        private System.Windows.Forms.PictureBox img_car;
        private System.Windows.Forms.Button btn_browser_image;
        private System.Windows.Forms.Label label12;
        private GroupBox gb_data_form;
        private Button btn_save;
        private Label label6;
        private TextBox txt_deposit_price;
        private DateTimePicker txt_car_year;
        private Label label3;
        private Label label7;
        private ComboBox cb_engine;
        private TextBox txt_car_price;
        private Button btn_exit;
        private DataGridView data_cars;
        private TextBox txt_km;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn engineType;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn numberOfKm;
        private DataGridViewTextBoxColumn rentByTime;
        private DataGridViewTextBoxColumn RentByDate;
        private DataGridViewTextBoxColumn depositPrice;
        private DataGridViewTextBoxColumn numberOfSeats;
        private Button btn_edit;
        private TextBox txt_id;
        private Button btn_export;
    }
}