using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Repository.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MiniStoreWinF.ManageProducts
{
    public partial class ImportWithNewSupplier : Form
    {
        public ImportWithNewSupplier()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "excel files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "select excel file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathToImport.Text = openFileDialog.FileName;
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Only for excel Microsoft offical!", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = true;
                    Microsoft.Office.Interop.Excel.Workbook xlWbook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWsheet, xlWsheet2, xlWsheet3;
                    object data = System.Reflection.Missing.Value;
                    xlWbook = excel.Workbooks.Add(data);

                    xlWsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.Add();
                    xlWsheet.Name = "Unit Data";
                    xlWsheet.Cells[1, 1].Value = "Sku";
                    xlWsheet.Cells[1, 2].Value = "UnitName";
                    xlWsheet.Cells[1, 3].Value = "QuantityUnit";
                    xlWsheet.Cells[1, 4].Value = "PriceImport";
                    xlWsheet.Cells[1, 5].Value = "PriceExport";

                    xlWsheet2 = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.Add();
                    xlWsheet2.Name = "Product Data";
                    xlWsheet2.Cells[1, 1].Value = "SKU";
                    xlWsheet2.Cells[1, 2].Value = "ProductType";
                    xlWsheet2.Cells[1, 3].Value = "NameProduct";
                    xlWsheet2.Cells[1, 4].Value = "IdSupplier";
                    xlWsheet2.Cells[1, 5].Value = "Mfg";
                    xlWsheet2.Cells[1, 6].Value = "Exp";
                    xlWsheet2.Cells[1, 7].Value = "DateImport";
                    xlWsheet2.Cells[1, 8].Value = "PictureProduct";
                    xlWsheet2.Cells[1, 9].Value = "StatusP";

                    xlWsheet3 = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.Add();
                    xlWsheet3.Name = "Supplier Data";
                    xlWsheet3.Cells[1, 1].Value = "IDSupplier";
                    xlWsheet3.Cells[1, 2].Value = "NameSupplier";
                    xlWsheet3.Cells[1, 3].Value = "Address";
                    xlWsheet3.Cells[1, 4].Value = "Note";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Can not find Microsoft offical in you device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                return;
            }
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            try
            {
                var filePath = txtPathToImport.Text;
                var dataImporter = new ImportProducts();
                DialogResult result = MessageBox.Show("You Want To Import?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    dataImporter.ImportDataFromExcelSupplier(filePath);
                    dataImporter.ImportDataFromExcel(filePath);
                    dataImporter.ImportDataFromExcelUnit(filePath);
                    txtPathToImport.Clear();
                    MessageBox.Show("Import Successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Import Fail !! You Should Check All Information In Excel Or File Excel Not Correct");
            }
        }
    }
}
