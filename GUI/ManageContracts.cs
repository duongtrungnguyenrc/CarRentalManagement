using System;
using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using BLL;

namespace GUI
{
    public partial class ManageContracts : Form
    {
        private string userID;

        public ManageContracts(string userID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form ở giữa màn hình khi show lên
            this.userID = userID;
            loadContract();
        }

       private void loadContract()
        {
            List<Contract> contracts = new List<Contract> ();
            Respond res = ContractsModel.GetAllContracts();
            if(res.getStatus())
            {
                contracts = (List<Contract>) res.getData();
                foreach(Contract contract in contracts)
                {
                    int rowIndex = data_contracts.Rows.Add(contract.contractId, contract.createDate, contract.startDate, contract.startTime, contract.endDate ,contract.endTime, contract.totalPrices, contract.paymentMethod, contract.status);
                    data_contracts.Rows[rowIndex].Tag = contract;
                }
            }
            else
            {
                MessageBox.Show(res.getDescription());
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CreateContract form = new CreateContract(this.userID);
            this.Hide();
            form.ShowDialog(this);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            //Create a new workbook
            var workbook = new XLWorkbook();

            //Create a new worksheet
            var worksheet = workbook.Worksheets.Add("Sheet1");

            //Export header row
            for (int i = 1; i <= data_contracts.Columns.Count; i++)
            {
                worksheet.Cell(1, i).Value = data_contracts.Columns[i - 1].HeaderText;
            }

            //Export data rows
            for (int i = 1; i <= data_contracts.Rows.Count; i++)
            {
                for (int j = 1; j <= data_contracts.Columns.Count; j++)
                {
                    var value = data_contracts.Rows[i - 1].Cells[j - 1].Value;
                    if (value != null)
                    {
                        worksheet.Cell(i + 1, j).Value = value.ToString();
                    }
                }
            }

            //Save the workbook
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            saveDialog.FileName = "Contracts.xlsx";

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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data_contracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Contract selectedRow = (Contract)data_contracts.Rows[e.RowIndex].Tag;

            ViewContract form = new ViewContract(this.userID, selectedRow);
            form.ShowDialog(this);
        }

        private void ManageContracts_Shown(object sender, EventArgs e)
        {
            data_contracts.Rows.Clear();
            loadContract();
        }
    }
}
