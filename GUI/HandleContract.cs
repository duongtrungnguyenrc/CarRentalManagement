using BLL;
using DocumentFormat.OpenXml.Wordprocessing;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI
{
    public partial class ViewContract : Form
    {
        private string userID;
        private Contract contract;
        public ViewContract(string userID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form ở giữa màn hình khi show lên
            this.userID = userID;
        }

        public ViewContract(string userID, Contract contract) : this(userID)
        {
            this.contract = contract;
        }

        private void HandleContract_Load(object sender, EventArgs e)
        {
            LoadContractCar();
            LoadContractCustomer();
            LoadContractInfo();
            if(String.Equals(this.contract.status, "Completed", StringComparison.OrdinalIgnoreCase))
            {
                LoadPostContract();
                DisableForm();
            }
        }

        private void LoadContractCar()
        {
            Respond carRes = CarsModel.GetCarById(contract.car.id);
            if (carRes.getStatus())
            {
                Car car = (Car)carRes.getData();

                System.Drawing.Image image = null;
                if (car.imgData != null && car.imgData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(car.imgData))
                    {
                        image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to load car image!", "Error");
                }
                img_car.Image = image;
                img_car.Tag = car;
                img_car.SizeMode = PictureBoxSizeMode.Zoom;

                gb_car.Text = car.name;
            }
            else
            {
                MessageBox.Show(carRes.getDescription());
            }
        }

        private void LoadContractCustomer()
        {
            Respond res = CustomerModel.getCusomerById(contract.customer.id);
            if (res.getStatus())
            {
                Customer customer = (Customer)res.getData();
                txt_name.Text = customer.name;
                txt_address.Text = customer.address;
                cb_gender.Text = customer.gender;
                txt_birth.Value = customer.birth;
                txt_phone.Text = customer.phone;
                txt_identifier.Text = customer.identifier;
                txt_driver_id.Text = customer.driverId;
            }
            else
            {
                MessageBox.Show(res.getDescription());
            }
        }

        private void LoadContractInfo() 
        {
            cb_pre_payment_method.Text = this.contract.paymentMethod;
            txt_pre_prices.Text = "" + this.contract.totalPrices;
            txt_pre_status.Text = this.contract.status;
            txt_start_date.Text = this.contract.startDate.ToString();
            txt_end_date.Text = this.contract.endDate.ToString();
            txt_start_time.Text = this.contract.startTime.ToString();
            txt_end_time.Text = this.contract.endTime.ToString();
            txt_pre_id.Text = this.contract.contractId;
        }

        private void LoadPostContract()
        {
            Respond res = ContractsModel.GetPostContractById(this.contract.contractId);

            if (res.getStatus())
            {
                PostContracts contract = (PostContracts) res.getData();
                txt_post_id.Text = contract.postContractId;
                cb_post_payment_method.Text = contract.paymentMethod;
                txt_extra_charge.Text = "" + contract.extraCharge;
                txt_note.Text = contract.note;
                lb_car_status.Hide();
                cb_car_status.Hide();
            }
            else
            {
                MessageBox.Show(res.getDescription(), "Error");
            }
        }

        private void btn_create_post_contract_Click(object sender, EventArgs e)
        {
            PostContracts postContracts = new PostContracts("", this.userID, txt_pre_id.Text, "completed", txt_note.Text, double.Parse(txt_extra_charge.Text), cb_post_payment_method.Text);

            Respond res = ContractsModel.CreatePostContract(postContracts);
            if (res.getStatus())
            {
                Car rentingCar = (Car) img_car.Tag;
                if(CarsModel.UpdateCarStatus(rentingCar.id, cb_car_status.Text).getStatus() &&
                ContractsModel.UpdateContractStatus(this.contract.contractId, "Completed").getStatus())
                {
                    DisableForm();
                    MessageBox.Show(res.getDescription(), "Success");
                    if(this.Owner != null)
                    {
                        this.Owner.Show();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show(res.getDescription(), "Error");
                    return;
                }
            }
            else
            {
                MessageBox.Show(res.getDescription(), "Error");
            }
        }

        private void DisableForm()
        {
            foreach (System.Windows.Forms.Control control in gb_post_contract.Controls)
            {
                if(!(control is Button))
                {
                    control.Enabled = false;
                }
            }
            btn_create_post_contract.Enabled = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
