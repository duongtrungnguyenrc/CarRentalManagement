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
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace GUI
{
    public partial class CreateContract : Form
    {
        private string userID;

        private Contract contract; 

        private ImageList imageList;
        public CreateContract(string userID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form ở giữa màn hình khi show lên
            this.userID = userID;
        }

        private void HandleContract_Load(object sender, EventArgs e)
        {
            // Tạo một ImageList mới
            this.imageList = new ImageList();
            imageList.ImageSize = new Size(300, 300); // Đặt kích thước của hình ảnh
            List<Car> cars = CarsModel.GetCars();

            System.Drawing.Image image = null;
            foreach (Car car in cars)
            {
                if (car.imgData != null && car.imgData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(car.imgData))
                    {
                        image = System.Drawing.Image.FromStream(ms);
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

        private void btn_create_contract_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer("", txt_name.Text, txt_birth.Value, txt_phone.Text, cb_gender.Text, txt_address.Text, txt_identifier.Text, txt_driver_id.Text);
            Respond res = CustomerModel.CreateNewCustomer(customer);
            if(res.getStatus())
            {
                customer.id = (string) res.getData();
            }
            else
            {
                MessageBox.Show(res.getDescription());
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

            double rentalTime = PricesModel.GetRentTime((DateTime)txt_start_date.Value, (DateTime)txt_end_date.Value, (DateTime)txt_start_time.Value, (DateTime)txt_end_time.Value);
            double rentalPrice = rentalTime >= 12 ? car.rentByDate : car.renByTime;

            Contract contract = new Contract("", this.userID ,customer, car, (DateTime)txt_start_date.Value, (DateTime)txt_end_date.Value, txt_start_time.Value.TimeOfDay, 
                txt_end_time.Value.TimeOfDay, new DateTime(), PricesModel.CalcPrices(rentalPrice, rentalTime), cb_payment_method.Text, "Operational"); 
            
            res = ContractsModel.CreateContract(contract);
            if(res.getStatus())
            {
                this.Close();
                ExportContract();
            }
            MessageBox.Show(res.getDescription());
        }


        private void ExportContract()
        {
            // Create a new PDF document
            Document document = new Document();
            string filePath = $"Contract.pdf";
            // Set up the PDF writer to write the document to a file
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Open the document
            document.Open();

            // Add content to the document
            document.Add(new Paragraph("Hello, World!"));

            // Close the document
            document.Close();
        }

    }
}
