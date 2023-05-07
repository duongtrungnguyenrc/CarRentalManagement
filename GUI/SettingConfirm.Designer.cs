namespace GUI
{
    partial class SettingConfirm
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
            this.txt_password_confirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.show_password = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.FormClosed += SettingConfirm_FormClosed;
            // 
            // txt_password_confirm
            // 
            this.txt_password_confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password_confirm.Location = new System.Drawing.Point(70, 120);
            this.txt_password_confirm.Name = "txt_password_confirm";
            this.txt_password_confirm.Size = new System.Drawing.Size(519, 50);
            this.txt_password_confirm.TabIndex = 0;
            this.txt_password_confirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirm password:";
            // 
            // show_password
            // 
            this.show_password.AutoSize = true;
            this.show_password.Location = new System.Drawing.Point(379, 78);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(210, 36);
            this.show_password.TabIndex = 44;
            this.show_password.Text = "Show password";
            this.show_password.UseVisualStyleBackColor = true;
            this.show_password.CheckedChanged += new System.EventHandler(this.show_password_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ok.Location = new System.Drawing.Point(336, 200);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(253, 69);
            this.btn_ok.TabIndex = 75;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(70, 200);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(254, 69);
            this.btn_cancel.TabIndex = 74;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // SettingConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(659, 331);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password_confirm);
            this.Name = "SettingConfirm";
            this.Text = "SettingConfirm";
            this.Load += new System.EventHandler(this.SettingConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SettingConfirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        #endregion

        private TextBox txt_password_confirm;
        private Label label1;
        private CheckBox show_password;
        private Button btn_ok;
        private Button btn_cancel;
    }
}