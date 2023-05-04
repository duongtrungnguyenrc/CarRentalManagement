namespace GUI
{
    partial class DisplayCars
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
            this.car_list = new System.Windows.Forms.ListView();
            this.car_chosing = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.car_chosing)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // car_list
            // 
            this.car_list.Location = new System.Drawing.Point(25, 609);
            this.car_list.Name = "car_list";
            this.car_list.Size = new System.Drawing.Size(2063, 614);
            this.car_list.TabIndex = 70;
            this.car_list.UseCompatibleStateImageBehavior = false;
            this.car_list.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // car_chosing
            // 
            this.car_chosing.Location = new System.Drawing.Point(32, 53);
            this.car_chosing.Name = "car_chosing";
            this.car_chosing.Size = new System.Drawing.Size(332, 267);
            this.car_chosing.TabIndex = 72;
            this.car_chosing.TabStop = false;
            // 
            // groupBox1
            // 
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
            // txt_driver_id
            // 
            this.txt_driver_id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_driver_id.Location = new System.Drawing.Point(732, 53);
            this.txt_driver_id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_driver_id.Name = "txt_driver_id";
            this.txt_driver_id.Size = new System.Drawing.Size(403, 39);
            this.txt_driver_id.TabIndex = 92;
            this.txt_driver_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(571, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 91;
            this.label2.Text = "Driver ID:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(732, 131);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(403, 189);
            this.txt_address.TabIndex = 90;
            this.txt_address.Text = "";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(181, 208);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(357, 39);
            this.txt_phone.TabIndex = 89;
            // 
            // txt_identifier
            // 
            this.txt_identifier.Location = new System.Drawing.Point(181, 286);
            this.txt_identifier.Name = "txt_identifier";
            this.txt_identifier.Size = new System.Drawing.Size(357, 39);
            this.txt_identifier.TabIndex = 88;
            // 
            // cb_gender
            // 
            this.cb_gender.AllowDrop = true;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(181, 131);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(357, 40);
            this.cb_gender.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(571, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 31);
            this.label7.TabIndex = 85;
            this.label7.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(33, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Phone:";
            // 
            // txt_name
            // 
            this.txt_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_name.Location = new System.Drawing.Point(181, 53);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(357, 39);
            this.txt_name.TabIndex = 74;
            // 
            // lb_km
            // 
            this.lb_km.AutoSize = true;
            this.lb_km.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_km.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_km.Location = new System.Drawing.Point(35, 289);
            this.lb_km.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_km.Name = "lb_km";
            this.lb_km.Size = new System.Drawing.Size(127, 31);
            this.lb_km.TabIndex = 71;
            this.lb_km.Text = "Identifier:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(35, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 31);
            this.label5.TabIndex = 70;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(35, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 69;
            this.label4.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_create_contract);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_end_time);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_end_date);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_start_time);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_start_date);
            this.groupBox2.Location = new System.Drawing.Point(1645, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 460);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rental infomations";
            // 
            // btn_create_contract
            // 
            this.btn_create_contract.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_create_contract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_create_contract.Location = new System.Drawing.Point(98, 363);
            this.btn_create_contract.Name = "btn_create_contract";
            this.btn_create_contract.Size = new System.Drawing.Size(272, 75);
            this.btn_create_contract.TabIndex = 99;
            this.btn_create_contract.Text = "Create contract";
            this.btn_create_contract.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(13, 271);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 31);
            this.label11.TabIndex = 98;
            this.label11.Text = "End time:";
            // 
            // txt_end_time
            // 
            this.txt_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt_end_time.Location = new System.Drawing.Point(163, 268);
            this.txt_end_time.Name = "txt_end_time";
            this.txt_end_time.Size = new System.Drawing.Size(261, 39);
            this.txt_end_time.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(13, 206);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 31);
            this.label12.TabIndex = 96;
            this.label12.Text = "End date:";
            // 
            // txt_end_date
            // 
            this.txt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_end_date.Location = new System.Drawing.Point(163, 203);
            this.txt_end_date.Name = "txt_end_date";
            this.txt_end_date.Size = new System.Drawing.Size(261, 39);
            this.txt_end_date.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(13, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 31);
            this.label10.TabIndex = 94;
            this.label10.Text = "Start time:";
            // 
            // txt_start_time
            // 
            this.txt_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt_start_time.Location = new System.Drawing.Point(163, 133);
            this.txt_start_time.Name = "txt_start_time";
            this.txt_start_time.Size = new System.Drawing.Size(261, 39);
            this.txt_start_time.TabIndex = 93;
            // 
            // label9
            // 
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
            this.txt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_start_date.Location = new System.Drawing.Point(163, 68);
            this.txt_start_date.Name = "txt_start_date";
            this.txt_start_date.Size = new System.Drawing.Size(261, 39);
            this.txt_start_date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(819, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create rental session";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_display_cars.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_display_cars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_display_cars.Location = new System.Drawing.Point(1348, 30);
            this.btn_display_cars.Name = "btn_display_cars";
            this.btn_display_cars.Size = new System.Drawing.Size(166, 56);
            this.btn_display_cars.TabIndex = 91;
            this.btn_display_cars.Text = "Display cars";
            this.btn_display_cars.UseVisualStyleBackColor = false;
            this.btn_display_cars.Click += new System.EventHandler(this.btn_display_cars_Click);
            // 
            // label8
            // 
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
            this.cb_engine_type.FormattingEnabled = true;
            this.cb_engine_type.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_engine_type.Location = new System.Drawing.Point(906, 38);
            this.cb_engine_type.Name = "cb_engine_type";
            this.cb_engine_type.Size = new System.Drawing.Size(383, 40);
            this.cb_engine_type.TabIndex = 89;
            // 
            // label6
            // 
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
            this.cb_car_type.FormattingEnabled = true;
            this.cb_car_type.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_car_type.Location = new System.Drawing.Point(273, 38);
            this.cb_car_type.Name = "cb_car_type";
            this.cb_car_type.Size = new System.Drawing.Size(383, 40);
            this.cb_car_type.TabIndex = 87;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.car_chosing);
            this.groupBox4.Location = new System.Drawing.Point(1226, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 351);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Car";
            // 
            // DisplayCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2114, 1245);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.car_list);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DisplayCars";
            this.Text = "DisplayCars";
            this.Load += new System.EventHandler(this.DisplayCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.car_chosing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ListView car_list;
        private PictureBox car_chosing;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
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
        private GroupBox groupBox4;
        private Button btn_create_contract;
        private Label label11;
        private DateTimePicker txt_end_time;
        private Label label12;
        private DateTimePicker txt_end_date;
        private Label label10;
        private DateTimePicker txt_start_time;
        private Label label9;
    }
}