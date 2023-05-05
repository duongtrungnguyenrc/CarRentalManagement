namespace GUI
{
    partial class Setting
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save_info = new System.Windows.Forms.Button();
            this.gb_user_info = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_shift = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_coefficients_salary = new System.Windows.Forms.TextBox();
            this.txt_birth = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_identity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_account = new System.Windows.Forms.GroupBox();
            this.show_password = new System.Windows.Forms.CheckBox();
            this.btn_save_account = new System.Windows.Forms.Button();
            this.btn_edit_info = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_account_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_sales = new System.Windows.Forms.DataGridView();
            this.contractId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.customer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_salary = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.gb_user_info.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_sales)).BeginInit();
            this.gb_salary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_save_info);
            this.groupBox2.Location = new System.Drawing.Point(1860, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 347);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(37, 219);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(165, 69);
            this.btn_exit.TabIndex = 74;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(37, 73);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(165, 69);
            this.btn_edit.TabIndex = 72;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save_info
            // 
            this.btn_save_info.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_save_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_info.Enabled = false;
            this.btn_save_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save_info.Location = new System.Drawing.Point(37, 144);
            this.btn_save_info.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_save_info.Name = "btn_save_info";
            this.btn_save_info.Size = new System.Drawing.Size(165, 69);
            this.btn_save_info.TabIndex = 73;
            this.btn_save_info.Text = "Save";
            this.btn_save_info.UseVisualStyleBackColor = false;
            this.btn_save_info.Click += new System.EventHandler(this.btn_save_info_Click);
            // 
            // gb_user_info
            // 
            this.gb_user_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_user_info.Controls.Add(this.txt_id);
            this.gb_user_info.Controls.Add(this.label15);
            this.gb_user_info.Controls.Add(this.cb_shift);
            this.gb_user_info.Controls.Add(this.txt_name);
            this.gb_user_info.Controls.Add(this.txt_address);
            this.gb_user_info.Controls.Add(this.label4);
            this.gb_user_info.Controls.Add(this.txt_coefficients_salary);
            this.gb_user_info.Controls.Add(this.txt_birth);
            this.gb_user_info.Controls.Add(this.label11);
            this.gb_user_info.Controls.Add(this.label5);
            this.gb_user_info.Controls.Add(this.cb_gender);
            this.gb_user_info.Controls.Add(this.label3);
            this.gb_user_info.Controls.Add(this.label6);
            this.gb_user_info.Controls.Add(this.label10);
            this.gb_user_info.Controls.Add(this.label7);
            this.gb_user_info.Controls.Add(this.label8);
            this.gb_user_info.Controls.Add(this.txt_phone);
            this.gb_user_info.Controls.Add(this.txt_identity);
            this.gb_user_info.Location = new System.Drawing.Point(25, 167);
            this.gb_user_info.Name = "gb_user_info";
            this.gb_user_info.Size = new System.Drawing.Size(1804, 347);
            this.gb_user_info.TabIndex = 78;
            this.gb_user_info.TabStop = false;
            this.gb_user_info.Text = "User infomations";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(177, 53);
            this.txt_id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(1558, 38);
            this.txt_id.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(73, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 31);
            this.label15.TabIndex = 71;
            this.label15.Text = "ID:";
            // 
            // cb_shift
            // 
            this.cb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_shift.Enabled = false;
            this.cb_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_shift.ForeColor = System.Drawing.Color.Black;
            this.cb_shift.FormattingEnabled = true;
            this.cb_shift.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Night"});
            this.cb_shift.Location = new System.Drawing.Point(699, 281);
            this.cb_shift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_shift.Name = "cb_shift";
            this.cb_shift.Size = new System.Drawing.Size(377, 39);
            this.cb_shift.TabIndex = 70;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(182, 124);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(361, 38);
            this.txt_name.TabIndex = 54;
            // 
            // txt_address
            // 
            this.txt_address.Enabled = false;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Location = new System.Drawing.Point(1235, 211);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(500, 103);
            this.txt_address.TabIndex = 69;
            this.txt_address.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(73, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 44;
            this.label4.Text = "Name";
            // 
            // txt_coefficients_salary
            // 
            this.txt_coefficients_salary.Enabled = false;
            this.txt_coefficients_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_coefficients_salary.ForeColor = System.Drawing.Color.Black;
            this.txt_coefficients_salary.Location = new System.Drawing.Point(1343, 128);
            this.txt_coefficients_salary.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_coefficients_salary.Name = "txt_coefficients_salary";
            this.txt_coefficients_salary.Size = new System.Drawing.Size(392, 38);
            this.txt_coefficients_salary.TabIndex = 66;
            // 
            // txt_birth
            // 
            this.txt_birth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_birth.CustomFormat = "yyyy/MM/dd";
            this.txt_birth.Enabled = false;
            this.txt_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_birth.Location = new System.Drawing.Point(182, 283);
            this.txt_birth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_birth.Name = "txt_birth";
            this.txt_birth.Size = new System.Drawing.Size(361, 38);
            this.txt_birth.TabIndex = 68;
            this.txt_birth.Value = new System.DateTime(2023, 5, 5, 23, 0, 25, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(1093, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 31);
            this.label11.TabIndex = 65;
            this.label11.Text = "Coefficients salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(73, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 31);
            this.label5.TabIndex = 45;
            this.label5.Text = "Gender";
            // 
            // cb_gender
            // 
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.Enabled = false;
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_gender.ForeColor = System.Drawing.Color.Black;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(182, 206);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(361, 39);
            this.cb_gender.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(584, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 63;
            this.label3.Text = "Shift";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(73, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 31);
            this.label6.TabIndex = 46;
            this.label6.Text = "Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1093, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 31);
            this.label10.TabIndex = 61;
            this.label10.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(584, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 31);
            this.label7.TabIndex = 47;
            this.label7.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(584, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 31);
            this.label8.TabIndex = 48;
            this.label8.Text = "Identity";
            // 
            // txt_phone
            // 
            this.txt_phone.Enabled = false;
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_phone.Location = new System.Drawing.Point(699, 126);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_phone.Size = new System.Drawing.Size(377, 38);
            this.txt_phone.TabIndex = 57;
            // 
            // txt_identity
            // 
            this.txt_identity.Enabled = false;
            this.txt_identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_identity.ForeColor = System.Drawing.Color.Black;
            this.txt_identity.Location = new System.Drawing.Point(699, 207);
            this.txt_identity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_identity.Name = "txt_identity";
            this.txt_identity.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_identity.Size = new System.Drawing.Size(377, 38);
            this.txt_identity.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2117, 143);
            this.panel1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(947, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Setting";
            // 
            // gb_account
            // 
            this.gb_account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_account.Controls.Add(this.show_password);
            this.gb_account.Controls.Add(this.btn_save_account);
            this.gb_account.Controls.Add(this.btn_edit_info);
            this.gb_account.Controls.Add(this.label13);
            this.gb_account.Controls.Add(this.cb_role);
            this.gb_account.Controls.Add(this.txt_password);
            this.gb_account.Controls.Add(this.label12);
            this.gb_account.Controls.Add(this.txt_user_name);
            this.gb_account.Controls.Add(this.label9);
            this.gb_account.Controls.Add(this.txt_account_id);
            this.gb_account.Controls.Add(this.label2);
            this.gb_account.Location = new System.Drawing.Point(25, 520);
            this.gb_account.Name = "gb_account";
            this.gb_account.Size = new System.Drawing.Size(1144, 534);
            this.gb_account.TabIndex = 80;
            this.gb_account.TabStop = false;
            this.gb_account.Text = "Account";
            // 
            // show_password
            // 
            this.show_password.AutoSize = true;
            this.show_password.Location = new System.Drawing.Point(247, 354);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(210, 36);
            this.show_password.TabIndex = 74;
            this.show_password.Text = "Show password";
            this.show_password.UseVisualStyleBackColor = true;
            this.show_password.CheckedChanged += new System.EventHandler(this.show_password_CheckedChanged);
            // 
            // btn_save_account
            // 
            this.btn_save_account.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_save_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_account.Enabled = false;
            this.btn_save_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save_account.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save_account.Location = new System.Drawing.Point(883, 432);
            this.btn_save_account.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_save_account.Name = "btn_save_account";
            this.btn_save_account.Size = new System.Drawing.Size(165, 69);
            this.btn_save_account.TabIndex = 73;
            this.btn_save_account.Text = "Save";
            this.btn_save_account.UseVisualStyleBackColor = false;
            this.btn_save_account.Click += new System.EventHandler(this.btn_save_account_Click);
            // 
            // btn_edit_info
            // 
            this.btn_edit_info.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_edit_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_edit_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit_info.Location = new System.Drawing.Point(706, 432);
            this.btn_edit_info.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_edit_info.Name = "btn_edit_info";
            this.btn_edit_info.Size = new System.Drawing.Size(165, 69);
            this.btn_edit_info.TabIndex = 72;
            this.btn_edit_info.Text = "Edit";
            this.btn_edit_info.UseVisualStyleBackColor = false;
            this.btn_edit_info.Click += new System.EventHandler(this.btn_edit_info_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(578, 305);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 31);
            this.label13.TabIndex = 68;
            this.label13.Text = "Role:";
            // 
            // cb_role
            // 
            this.cb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_role.Enabled = false;
            this.cb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_role.ForeColor = System.Drawing.Color.Black;
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "ADMIN",
            "STAFF"});
            this.cb_role.Location = new System.Drawing.Point(687, 300);
            this.cb_role.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(361, 45);
            this.cb_role.TabIndex = 69;
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(247, 299);
            this.txt_password.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(291, 44);
            this.txt_password.TabIndex = 60;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(68, 305);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 31);
            this.label12.TabIndex = 59;
            this.label12.Text = "Password:";
            // 
            // txt_user_name
            // 
            this.txt_user_name.Enabled = false;
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_user_name.ForeColor = System.Drawing.Color.Black;
            this.txt_user_name.Location = new System.Drawing.Point(247, 224);
            this.txt_user_name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(801, 44);
            this.txt_user_name.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(68, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 31);
            this.label9.TabIndex = 57;
            this.label9.Text = "User name:";
            // 
            // txt_account_id
            // 
            this.txt_account_id.Enabled = false;
            this.txt_account_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_account_id.ForeColor = System.Drawing.Color.Black;
            this.txt_account_id.Location = new System.Drawing.Point(145, 154);
            this.txt_account_id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_account_id.Name = "txt_account_id";
            this.txt_account_id.Size = new System.Drawing.Size(903, 44);
            this.txt_account_id.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(68, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 31);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID:";
            // 
            // data_sales
            // 
            this.data_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractId,
            this.customer,
            this.car,
            this.revenue});
            this.data_sales.Location = new System.Drawing.Point(1203, 674);
            this.data_sales.Name = "data_sales";
            this.data_sales.RowHeadersWidth = 82;
            this.data_sales.RowTemplate.Height = 41;
            this.data_sales.Size = new System.Drawing.Size(885, 380);
            this.data_sales.TabIndex = 81;
            // 
            // contractId
            // 
            this.contractId.HeaderText = "Contract id";
            this.contractId.MinimumWidth = 10;
            this.contractId.Name = "contractId";
            this.contractId.Width = 200;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.MinimumWidth = 10;
            this.customer.Name = "customer";
            this.customer.Width = 200;
            // 
            // car
            // 
            this.car.HeaderText = "Car";
            this.car.MinimumWidth = 10;
            this.car.Name = "car";
            this.car.Width = 200;
            // 
            // revenue
            // 
            this.revenue.HeaderText = "Revenue";
            this.revenue.MinimumWidth = 10;
            this.revenue.Name = "revenue";
            this.revenue.Width = 200;
            // 
            // gb_salary
            // 
            this.gb_salary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_salary.Controls.Add(this.label14);
            this.gb_salary.Controls.Add(this.txt_salary);
            this.gb_salary.Location = new System.Drawing.Point(1202, 520);
            this.gb_salary.Name = "gb_salary";
            this.gb_salary.Size = new System.Drawing.Size(886, 147);
            this.gb_salary.TabIndex = 82;
            this.gb_salary.TabStop = false;
            this.gb_salary.Text = "Salary";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(135, 70);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 31);
            this.label14.TabIndex = 58;
            this.label14.Text = "Salary:";
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_salary.ForeColor = System.Drawing.Color.Black;
            this.txt_salary.Location = new System.Drawing.Point(250, 64);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.ReadOnly = true;
            this.txt_salary.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_salary.Size = new System.Drawing.Size(518, 44);
            this.txt_salary.TabIndex = 59;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2117, 1082);
            this.Controls.Add(this.gb_salary);
            this.Controls.Add(this.data_sales);
            this.Controls.Add(this.gb_account);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_user_info);
            this.Controls.Add(this.panel1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.groupBox2.ResumeLayout(false);
            this.gb_user_info.ResumeLayout(false);
            this.gb_user_info.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_account.ResumeLayout(false);
            this.gb_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_sales)).EndInit();
            this.gb_salary.ResumeLayout(false);
            this.gb_salary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Button btn_exit;
        private Button btn_edit;
        private GroupBox gb_user_info;
        private TextBox txt_name;
        private RichTextBox txt_address;
        private Label label4;
        private TextBox txt_coefficients_salary;
        private DateTimePicker txt_birth;
        private Label label11;
        private Label label5;
        private ComboBox cb_gender;
        private Label label3;
        private Label label6;
        private Label label10;
        private Label label7;
        private Label label8;
        private TextBox txt_phone;
        private TextBox txt_identity;
        private Panel panel1;
        private Label label1;
        private GroupBox gb_account;
        private Button btn_save_account;
        private Button btn_edit_info;
        private Label label13;
        private ComboBox cb_role;
        private TextBox txt_password;
        private Label label12;
        private TextBox txt_user_name;
        private Label label9;
        private TextBox txt_account_id;
        private Label label2;
        private Button btn_save_info;
        private DataGridView data_sales;
        private ComboBox cb_shift;
        private GroupBox gb_salary;
        private Label label14;
        private TextBox txt_salary;
        private DataGridViewLinkColumn contractId;
        private DataGridViewLinkColumn customer;
        private DataGridViewTextBoxColumn car;
        private DataGridViewTextBoxColumn revenue;
        private TextBox txt_id;
        private Label label15;
        private CheckBox show_password;
    }
}