namespace GUI
{
    partial class ManageContracts
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.data_contracts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_contracts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            this.FormClosed += ManageContracts_FormClosed;
            this.Shown += ManageContracts_Shown;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1881, 143);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(712, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Rental System";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(997, 67);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(165, 89);
            this.btn_exit.TabIndex = 73;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(643, 67);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(165, 89);
            this.btn_add.TabIndex = 69;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // data_contracts
            // 
            this.data_contracts.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.data_contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_contracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.createDate,
            this.startDate,
            this.startTime,
            this.endDate,
            this.endTime,
            this.totalPrices,
            this.paymentMethod,
            this.status});
            this.data_contracts.Location = new System.Drawing.Point(30, 404);
            this.data_contracts.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.data_contracts.Name = "data_contracts";
            this.data_contracts.RowHeadersWidth = 82;
            this.data_contracts.Size = new System.Drawing.Size(1819, 704);
            this.data_contracts.TabIndex = 84;
            this.data_contracts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_contracts_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.Width = 200;
            // 
            // createDate
            // 
            this.createDate.HeaderText = "Create date";
            this.createDate.MinimumWidth = 10;
            this.createDate.Name = "createDate";
            this.createDate.Width = 200;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Start date";
            this.startDate.MinimumWidth = 10;
            this.startDate.Name = "startDate";
            this.startDate.Width = 200;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Start time";
            this.startTime.MinimumWidth = 10;
            this.startTime.Name = "startTime";
            this.startTime.Width = 200;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "End date";
            this.endDate.MinimumWidth = 10;
            this.endDate.Name = "endDate";
            this.endDate.Width = 200;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "End time";
            this.endTime.MinimumWidth = 10;
            this.endTime.Name = "endTime";
            this.endTime.Width = 200;
            // 
            // totalPrices
            // 
            this.totalPrices.HeaderText = "Total prices";
            this.totalPrices.MinimumWidth = 10;
            this.totalPrices.Name = "totalPrices";
            this.totalPrices.Width = 200;
            // 
            // paymentMethod
            // 
            this.paymentMethod.HeaderText = "Payment method";
            this.paymentMethod.MinimumWidth = 10;
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Width = 200;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 10;
            this.status.Name = "status";
            this.status.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_export);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Location = new System.Drawing.Point(30, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1819, 200);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_export.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_export.Location = new System.Drawing.Point(820, 67);
            this.btn_export.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(165, 89);
            this.btn_export.TabIndex = 74;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ManageContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1881, 1133);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_contracts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ManageContracts";
            this.Text = "ManageContract";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_contracts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ManageContracts_FormClosed(object sender, FormClosedEventArgs e)
        {
           if(this.Owner!= null)
            {
                this.Owner.Show();
            }
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView data_contracts;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn createDate;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn startTime;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewTextBoxColumn endTime;
        private DataGridViewTextBoxColumn totalPrices;
        private DataGridViewTextBoxColumn paymentMethod;
        private DataGridViewTextBoxColumn status;
        private Button btn_export;
    }
}