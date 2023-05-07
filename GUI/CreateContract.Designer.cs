namespace GUI
{
    partial class CreateContract
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
            this.cars_list = new System.Windows.Forms.ListView();
            this.car_chosing = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_driver_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_identifier = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_km = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_rental_time = new System.Windows.Forms.GroupBox();
            this.cb_payment_method = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_create_contract = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_end_time = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_end_date = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_start_time = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_start_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_display_cars = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_engine_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_car_type = new System.Windows.Forms.ComboBox();
            this.gb_car = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.car_chosing)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_rental_time.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_car.SuspendLayout();
            this.SuspendLayout();
            // 
            // cars_list
            // 
            this.cars_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cars_list.Location = new System.Drawing.Point(25, 609);
            this.cars_list.MultiSelect = false;
            this.cars_list.Name = "cars_list";
            this.cars_list.Size = new System.Drawing.Size(2063, 614);
            this.cars_list.TabIndex = 70;
            this.cars_list.UseCompatibleStateImageBehavior = false;
            this.cars_list.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // car_chosing
            // 
            this.car_chosing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.car_chosing.Location = new System.Drawing.Point(32, 53);
            this.car_chosing.Name = "car_chosing";
            this.car_chosing.Size = new System.Drawing.Size(332, 267);
            this.car_chosing.TabIndex = 72;
            this.car_chosing.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_birth);
            this.groupBox1.Controls.Add(this.txt_driver_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_identifier);
            this.groupBox1.Controls.Add(this.cb_gender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.lb_km);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 352);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer infomations";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(35, 134);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 31);
            this.label13.TabIndex = 94;
            this.label13.Text = "Birth:";
            // 
            // txt_birth
            // 
            this.txt_birth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_birth.CalendarFont = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_birth.Checked = false;
            this.txt_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_birth.Location = new System.Drawing.Point(181, 135);
            this.txt_birth.Name = "txt_birth";
            this.txt_birth.Size = new System.Drawing.Size(357, 39);
            this.txt_birth.TabIndex = 2;
            // 
            // txt_driver_id
            // 
            this.txt_driver_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_driver_id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_driver_id.Location = new System.Drawing.Point(732, 134);
            this.txt_driver_id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_driver_id.Name = "txt_driver_id";
            this.txt_driver_id.Size = new System.Drawing.Size(403, 39);
            this.txt_driver_id.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(571, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 91;
            this.label2.Text = "Driver ID:";
            // 
            // txt_address
            // 
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.Location = new System.Drawing.Point(732, 208);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(403, 108);
            this.txt_address.TabIndex = 7;
            this.txt_address.Text = "";
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phone.Location = new System.Drawing.Point(181, 277);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(357, 39);
            this.txt_phone.TabIndex = 4;
            // 
            // txt_identifier
            // 
            this.txt_identifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_identifier.Location = new System.Drawing.Point(732, 55);
            this.txt_identifier.Name = "txt_identifier";
            this.txt_identifier.Size = new System.Drawing.Size(403, 39);
            this.txt_identifier.TabIndex = 5;
            // 
            // cb_gender
            // 
            this.cb_gender.AllowDrop = true;
            this.cb_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(181, 207);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(357, 40);
            this.cb_gender.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(571, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 31);
            this.label7.TabIndex = 85;
            this.label7.Text = "Address:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(33, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Phone:";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_name.Location = new System.Drawing.Point(181, 63);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(357, 39);
            this.txt_name.TabIndex = 1;
            // 
            // lb_km
            // 
            this.lb_km.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_km.AutoSize = true;
            this.lb_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_km.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_km.Location = new System.Drawing.Point(571, 57);
            this.lb_km.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_km.Name = "lb_km";
            this.lb_km.Size = new System.Drawing.Size(127, 31);
            this.lb_km.TabIndex = 71;
            this.lb_km.Text = "Identifier:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(33, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 31);
            this.label5.TabIndex = 70;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(35, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 69;
            this.label4.Text = "Name:";
            // 
            // gb_rental_time
            // 
            this.gb_rental_time.Controls.Add(this.cb_payment_method);
            this.gb_rental_time.Controls.Add(this.label15);
            this.gb_rental_time.Controls.Add(this.btn_create_contract);
            this.gb_rental_time.Controls.Add(this.label11);
            this.gb_rental_time.Controls.Add(this.txt_end_time);
            this.gb_rental_time.Controls.Add(this.label12);
            this.gb_rental_time.Controls.Add(this.txt_end_date);
            this.gb_rental_time.Controls.Add(this.label10);
            this.gb_rental_time.Controls.Add(this.txt_start_time);
            this.gb_rental_time.Controls.Add(this.label9);
            this.gb_rental_time.Controls.Add(this.txt_start_date);
            this.gb_rental_time.Location = new System.Drawing.Point(1645, 129);
            this.gb_rental_time.Name = "gb_rental_time";
            this.gb_rental_time.Size = new System.Drawing.Size(443, 460);
            this.gb_rental_time.TabIndex = 74;
            this.gb_rental_time.TabStop = false;
            this.gb_rental_time.Text = "Rental infomations";
            // 
            // cb_payment_method
            // 
            this.cb_payment_method.AllowDrop = true;
            this.cb_payment_method.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_payment_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_payment_method.FormattingEnabled = true;
            this.cb_payment_method.Items.AddRange(new object[] {
            "Banking",
            "Cast payment"});
            this.cb_payment_method.Location = new System.Drawing.Point(258, 298);
            this.cb_payment_method.Name = "cb_payment_method";
            this.cb_payment_method.Size = new System.Drawing.Size(166, 40);
            this.cb_payment_method.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(13, 301);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 31);
            this.label15.TabIndex = 100;
            this.label15.Text = "Payment method:";
            // 
            // btn_create_contract
            // 
            this.btn_create_contract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create_contract.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_create_contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_contract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_create_contract.Location = new System.Drawing.Point(98, 363);
            this.btn_create_contract.Name = "btn_create_contract";
            this.btn_create_contract.Size = new System.Drawing.Size(272, 75);
            this.btn_create_contract.TabIndex = 12;
            this.btn_create_contract.Text = "Create contract";
            this.btn_create_contract.UseVisualStyleBackColor = false;
            this.btn_create_contract.Click += new System.EventHandler(this.btn_create_contract_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(13, 242);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 31);
            this.label11.TabIndex = 98;
            this.label11.Text = "End time:";
            // 
            // txt_end_time
            // 
            this.txt_end_time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt_end_time.Location = new System.Drawing.Point(163, 239);
            this.txt_end_time.Name = "txt_end_time";
            this.txt_end_time.Size = new System.Drawing.Size(261, 39);
            this.txt_end_time.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(13, 184);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 31);
            this.label12.TabIndex = 96;
            this.label12.Text = "End date:";
            // 
            // txt_end_date
            // 
            this.txt_end_date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_end_date.Location = new System.Drawing.Point(163, 181);
            this.txt_end_date.Name = "txt_end_date";
            this.txt_end_date.Size = new System.Drawing.Size(261, 39);
            this.txt_end_date.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(13, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 31);
            this.label10.TabIndex = 94;
            this.label10.Text = "Start time:";
            // 
            // txt_start_time
            // 
            this.txt_start_time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt_start_time.Location = new System.Drawing.Point(163, 124);
            this.txt_start_time.Name = "txt_start_time";
            this.txt_start_time.Size = new System.Drawing.Size(261, 39);
            this.txt_start_time.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(13, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 31);
            this.label9.TabIndex = 92;
            this.label9.Text = "Start date:";
            // 
            // txt_start_date
            // 
            this.txt_start_date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_start_date.Location = new System.Drawing.Point(163, 68);
            this.txt_start_date.Name = "txt_start_date";
            this.txt_start_date.Size = new System.Drawing.Size(261, 39);
            this.txt_start_date.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(836, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create contract";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2114, 119);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_display_cars);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cb_engine_type);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cb_car_type);
            this.groupBox3.Location = new System.Drawing.Point(25, 487);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1593, 102);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // btn_display_cars
            // 
            this.btn_display_cars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_display_cars.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_display_cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_display_cars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_display_cars.Location = new System.Drawing.Point(1348, 30);
            this.btn_display_cars.Name = "btn_display_cars";
            this.btn_display_cars.Size = new System.Drawing.Size(166, 56);
            this.btn_display_cars.TabIndex = 91;
            this.btn_display_cars.Text = "Display cars";
            this.btn_display_cars.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(732, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 31);
            this.label8.TabIndex = 90;
            this.label8.Text = "Engine type:";
            // 
            // cb_engine_type
            // 
            this.cb_engine_type.AllowDrop = true;
            this.cb_engine_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_engine_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_engine_type.FormattingEnabled = true;
            this.cb_engine_type.Items.AddRange(new object[] {
            "gasoline",
            "diesel",
            "electricity",
            "hybrid"});
            this.cb_engine_type.Location = new System.Drawing.Point(906, 38);
            this.cb_engine_type.Name = "cb_engine_type";
            this.cb_engine_type.Size = new System.Drawing.Size(383, 40);
            this.cb_engine_type.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(138, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 31);
            this.label6.TabIndex = 88;
            this.label6.Text = "Car type:";
            // 
            // cb_car_type
            // 
            this.cb_car_type.AllowDrop = true;
            this.cb_car_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_car_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_car_type.FormattingEnabled = true;
            this.cb_car_type.Items.AddRange(new object[] {
            "4 seats",
            "5 seats",
            "7 seats"});
            this.cb_car_type.Location = new System.Drawing.Point(273, 38);
            this.cb_car_type.Name = "cb_car_type";
            this.cb_car_type.Size = new System.Drawing.Size(383, 40);
            this.cb_car_type.TabIndex = 87;
            // 
            // gb_car
            // 
            this.gb_car.Controls.Add(this.car_chosing);
            this.gb_car.Location = new System.Drawing.Point(1226, 129);
            this.gb_car.Name = "gb_car";
            this.gb_car.Size = new System.Drawing.Size(392, 351);
            this.gb_car.TabIndex = 76;
            this.gb_car.TabStop = false;
            this.gb_car.Text = "Car";
            // 
            // CreateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2114, 1245);
            this.Controls.Add(this.gb_car);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_rental_time);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cars_list);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateContract";
            this.Text = "ManageContract";
            this.Load += new System.EventHandler(this.HandleContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.car_chosing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_rental_time.ResumeLayout(false);
            this.gb_rental_time.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_car.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void CreateContract_FormClosed(object sender, FormClosedEventArgs e)
        {
           if(this.Owner!= null)
            {
                this.Owner.Show();
            }
        }

        #endregion
        private ListView cars_list;
        private PictureBox car_chosing;
        private GroupBox groupBox1;
        private GroupBox gb_rental_time;
        private Label label1;
        private Panel panel1;
        private TextBox txt_identifier;
        private ComboBox cb_gender;
        private Label label7;
        private Label label3;
        private TextBox txt_name;
        private Label lb_km;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txt_phone;
        private TextBox txt_driver_id;
        private Label label2;
        private RichTextBox txt_address;
        private DateTimePicker txt_start_date;
        private Button btn_display_cars;
        private Label label8;
        private ComboBox cb_engine_type;
        private Label label6;
        private ComboBox cb_car_type;
        private GroupBox gb_car;
        private Button btn_create_contract;
        private Label label11;
        private DateTimePicker txt_end_time;
        private Label label12;
        private DateTimePicker txt_end_date;
        private Label label10;
        private DateTimePicker txt_start_time;
        private Label label9;
        private Label label13;
        private DateTimePicker txt_birth;
        private ComboBox cb_payment_method;
        private Label label15;
    }
}