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
    public partial class DisplayCars : Form
    {
        private ImageList imageList;
        public DisplayCars()
        {
            InitializeComponent();
        }

        private void DisplayCars_Load(object sender, EventArgs e)
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
                car_list.LargeImageList = imageList;
                car_list.Items.Add(new ListViewItem(car.name, car.id));
            }
            // Gán ImageList vào thuộc tính LargeImageList của ListView
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (car_list.SelectedItems.Count > 0)
            {
                // Lấy index của phần tử đang được chọn trong ListView
                int selectedIndex = car_list.SelectedItems[0].Index;

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
    }
}
