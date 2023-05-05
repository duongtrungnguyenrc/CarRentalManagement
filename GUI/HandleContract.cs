using BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class HandleContract : Form
    {
        private string userID;

        private ImageList imageList;
        public HandleContract(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void HandleContract_Load(object sender, EventArgs e)
        {
            // Tạo một ImageList mới
            this.imageList = new ImageList();
            imageList.ImageSize = new Size(300, 300); // Đặt kích thước của hình ảnh

            DataModel model = new DataModel();
            List<Car> cars = model.GetCars();

            Image image = null;
            foreach (Car car in cars)
            {
                if (car.imgData != null && car.imgData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(car.imgData))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                imageList.Images.Add(car.id, image.GetThumbnailImage(300, 300, null, IntPtr.Zero));
                cars_list.LargeImageList = imageList;
                cars_list.Items.Add(new ListViewItem(car.name, car.id) { Tag = car });
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cars_list.SelectedItems.Count > 0)
            {
                // Lấy index của phần tử đang được chọn trong ListView
                int selectedIndex = cars_list.SelectedItems[0].Index;

                // Hiển thị hình ảnh tương ứng từ ImageList
                car_chosing.Image = this.imageList.Images[selectedIndex];
            }
        }

        private void txt_car_year_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_display_cars_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_create_contract_Click(object sender, EventArgs e)
        {
            DataModel model = new DataModel();
            Customer customer = new Customer("", txt_name.Text, txt_birth.Value, txt_phone.Text, cb_gender.Text, txt_address.Text, txt_identifier.Text, txt_driver_id.Text);
            Respond res = model.CreateNewCustomer(customer);
            if(res.getStatus())
            {
                customer.id = (string) res.getData();
            }
            else
            {
                return;
            }
            Car car = null;
            if (cars_list.SelectedItems.Count > 0)
            {
                car = (Car)cars_list.SelectedItems[0].Tag;
            }
            else
            {
                MessageBox.Show("Please select car!", "ERROR");
                return;
            }

            double rentalTime = GetRentTime((DateTime)txt_start_date.Value, (DateTime)txt_end_date.Value, (DateTime)txt_start_time.Value, (DateTime)txt_end_time.Value);
            double rentalPrice = rentalTime >= 12 ? car.rentByDate : car.renByTime;

            Contract contract = new Contract("", this.userID ,customer, car, (DateTime)txt_start_date.Value, (DateTime)txt_end_date.Value, txt_start_time.Value.TimeOfDay, txt_end_time.Value.TimeOfDay, new DateTime(), calcPrices(rentalPrice, rentalTime), "", ""); 
            
            res = model.CreateContract(contract);
            MessageBox.Show(res.getDescription());
        }

        private double GetRentTime(DateTime rentalStartDate, DateTime rentalEndDate, DateTime rentalStartTime, DateTime rentalEndTime)
        {
            DateTime startDateTime = rentalStartDate.Date + rentalStartTime.TimeOfDay;
            DateTime endDateTime = rentalEndDate.Date + rentalEndTime.TimeOfDay;

            TimeSpan duration = endDateTime - startDateTime;
            int days = duration.Days;
            double hours = duration.TotalHours - (days * 24);

            return days * 24 + hours;
        }

        private double calcPrices(double rentalPrice, double rentalTime)
        {
            return rentalTime * rentalPrice;
        }

    }
}
