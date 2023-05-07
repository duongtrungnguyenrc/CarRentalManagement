using BLL;
using ClosedXML.Excel;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GUI
{
    public partial class ManagerCars : Form
    {
        public ManagerCars()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form ở giữa màn hình khi show lên
            loadCars();
        }

        private void loadCars()
        {
            List<Car> cars = CarsModel.GetCars();
            data_cars.RowTemplate.Height = 200; // set image height is 200 pixel

            foreach (Car car in cars)
            {
                // Read image data from byte[] and convert it to Image
                Image image = null;
                if (car.imgData != null && car.imgData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(car.imgData))
                    {
                        image = Image.FromStream(ms);
                    }
                }

                // Add data to the image column cell
                int rowIndex = data_cars.Rows.Add("", car.id, car.name, car.engineType, car.year, car.price, car.numberOfKm, car.renByTime, car.rentByDate, car.depositPrice, car.numberOfSeats);
                DataGridViewCell cell = data_cars.Rows[rowIndex].Cells["image"];
                cell.Value = image;

                // Get the image column
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)data_cars.Columns["image"];

                // Set the image layout
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; // Set the image zoom level to fit the cell size

                // Set other display properties
                imgCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center-align the image in the cell
                imgCol.DefaultCellStyle.NullValue = null; // Display a default image if the cell value is null
            }

        }


        private void btn_browser_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;
                Image image = Image.FromFile(filePath);

                // Assign the image to the PictureBox
                img_car.SizeMode = PictureBoxSizeMode.CenterImage;
                img_car.Image = image;
                img_car.ImageLocation = filePath;
            }
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearForm()
        {
            foreach (Control childControl in gb_data_form.Controls)
            {
                if (childControl is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (childControl is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = 0;
                }
                else if (childControl is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
                else if (childControl is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                }
            }
        }


        private void data_cars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Enable edit and delete
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_save.Enabled = false;

            //push data to form
            DataGridViewRow row = data_cars.Rows[e.RowIndex];
            img_car.Image = (Image)row.Cells["image"].Value;
            txt_name.Text = row.Cells["name"].Value.ToString();
            cb_engine.Text = row.Cells["engineType"].Value.ToString();
            txt_car_year.Value = (DateTime)row.Cells["year"].Value;
            txt_car_price.Text = row.Cells["price"].Value.ToString();
            txt_km.Text = row.Cells["numberOfKm"].Value.ToString();
            txt_hour_rent.Text = row.Cells["rentbyTime"].Value.ToString();
            txt_day_rent.Text = row.Cells["rentByDate"].Value.ToString();
            txt_deposit_price.Text = row.Cells["depositPrice"].Value.ToString();
            cb_number_of_seats.Text = row.Cells["numberOfSeats"].Value.ToString();
            txt_id.Text = row.Cells["id"].Value.ToString();
            img_car.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(cb_engine.Text) || txt_car_year.Value == null)
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }

            if (img_car.Image == null)
            {
                MessageBox.Show("Please choose an image!");
                return;
            }

            byte[] imgData = null;
            using (MemoryStream ms = new MemoryStream())
            {
                img_car.Image.Save(ms, ImageFormat.Jpeg);
                imgData = ms.ToArray();
            }

            if (!double.TryParse(txt_car_price.Text, out double carPrice))
            {
                MessageBox.Show("Invalid car price!");
                return;
            }

            double numberOfKm = 0;
            if (double.TryParse(txt_km.Text, out double km))
            {
                numberOfKm = km;
            }

            if (!double.TryParse(txt_deposit_price.Text, out double depositPrice))
            {
                MessageBox.Show("Invalid deposit price!");
                return;
            }


            DateTime carYear = txt_car_year.Value;
            int numberOfSeats = 4;

            Car car = new Car("", txt_name.Text, imgData, carPrice, carYear, numberOfKm, double.Parse(txt_hour_rent.Text),
                              double.Parse(txt_day_rent.Text), depositPrice, cb_engine.Text, numberOfSeats, "");

            Respond res = CarsModel.AddNewCar(car);
            if (res.getStatus())
            {
                MessageBox.Show("Successfully added new car!");
                data_cars.Rows.Clear();
                loadCars();
                clearForm();
            }
            else
            {
                MessageBox.Show("Failed to add new car!");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(cb_engine.Text) || txt_car_year.Value == null)
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }

            if (img_car.Image == null)
            {
                MessageBox.Show("Please choose an image!");
                return;
            }

            byte[] imgData = null;
            using (MemoryStream ms = new MemoryStream())
            {
                img_car.Image.Save(ms, ImageFormat.Bmp);
                imgData = ms.ToArray();
            }

            if (!double.TryParse(txt_car_price.Text, out double carPrice))
            {
                MessageBox.Show("Invalid car price!");
                return;
            }

            double numberOfKm = 0;
            if (double.TryParse(txt_km.Text, out double km))
            {
                numberOfKm = km;
            }

            if (!double.TryParse(txt_deposit_price.Text, out double depositPrice))
            {
                MessageBox.Show("Invalid deposit price!");
                return;
            }


            DateTime carYear = txt_car_year.Value;
            int numberOfSeats = 4;

            Car car = new Car(txt_id.Text, txt_name.Text, imgData, carPrice, carYear, numberOfKm, double.Parse(txt_hour_rent.Text),
                              double.Parse(txt_day_rent.Text), depositPrice, cb_engine.Text, numberOfSeats, "");

            Respond res = CarsModel.UpdateCar(car);
            if (res.getStatus())
            {
                MessageBox.Show("Successfully update car!");
                data_cars.Rows.Clear();
                loadCars();
                clearForm();
            }
            else
            {
                MessageBox.Show("Failed to update car!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Respond res = CarsModel.DeleteCar(txt_id.Text);
            if (res.getStatus())
            {
                MessageBox.Show("Successfully delete new car!");
            }
            else
            {
                MessageBox.Show("Failed to delete new car!");
            }
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            //Create a new workbook
            var workbook = new XLWorkbook();

            //Create a new worksheet
            var worksheet = workbook.Worksheets.Add("Sheet1");

            //Export header row
            for (int i = 2; i <= data_cars.Columns.Count; i++)
            {
                worksheet.Cell(1, i).Value = data_cars.Columns[i - 1].HeaderText;
            }

            //Export data rows
            for (int i = 1; i <= data_cars.Rows.Count; i++)
            {
                for (int j = 2; j <= data_cars.Columns.Count; j++)
                {
                    var value = data_cars.Rows[i - 1].Cells[j - 1].Value;
                    if (value != null)
                    {
                        worksheet.Cell(i + 1, j).Value = value.ToString();
                    }
                }
            }

            //Save the workbook
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            saveDialog.FileName = "Cars.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    File.WriteAllBytes(saveDialog.FileName, stream.ToArray());
                }

                MessageBox.Show("Export completed!");
            }
        }
    }
}
