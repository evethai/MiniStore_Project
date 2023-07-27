using MiniStoreWinF.ManageSalary;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.ManageProducts
{
    public partial class frmCreate : Form
    {
        Utinity u = new Utinity();
        SupplierServices _AddSup;
        ProductService _AddPro;
        UnitService _AddUnit;
        SupplierServices _idSup;
        SupplierServices _idSuplast;
        ProductService _SKU;
        ProductService _SKULast;
        UnitServices _IdUnit;
        public frmCreate()
        {
            InitializeComponent();

        }

        private int formIndex = 0;
        private Type[] formTypes = new Type[]
        {
        typeof(ManageProducts.frmCreateSupplier),
        typeof(ManageProducts.frmCreateProduct),
        typeof(ManageProducts.frmCreateUnit)
        };
        private Form currentForm;
        private void SaveCurrentFormData()
        {
            if (currentForm != null)
            {
                if (currentForm is ManageProducts.frmCreateProduct)
                {
                    var productForm = (ManageProducts.frmCreateProduct)currentForm;
                    FormDataStorage.CreateProductData.ProductData = productForm.TextBoxProductData.Text;
                    FormDataStorage.CreateProductData.Status = productForm.TextBoxProductData7.Text;
                    FormDataStorage.CreateProductData.Type = productForm.TextBoxProductData1.Text;
                    FormDataStorage.CreateProductData.IDsup = productForm.TextBoxProductData2.Text;
                    FormDataStorage.CreateProductData.MFG = productForm.TextBoxProductData4.Value != DateTime.MinValue ? productForm.TextBoxProductData4.Value : DateTime.Today;
                    FormDataStorage.CreateProductData.EXP = productForm.TextBoxProductData3.Value != DateTime.MinValue ? productForm.TextBoxProductData3.Value : DateTime.Today;
                    FormDataStorage.CreateProductData.DateImport = productForm.TextBoxProductData5.Value != DateTime.MinValue ? productForm.TextBoxProductData5.Value : DateTime.Today;
                    FormDataStorage.CreateProductData.Path = productForm.TextBoxProductData9.Text;
                    FormDataStorage.CreateProductData.picture = productForm.TextBoxProductData8.Image;
                }
                else if (currentForm is ManageProducts.frmCreateUnit)
                {
                    var unitForm = (ManageProducts.frmCreateUnit)currentForm;
                    FormDataStorage.CreateUnit.SkuProduct = unitForm.textBoxUnitData1.Text;
                    FormDataStorage.CreateUnit.NameUnit = unitForm.textBoxUnitData.Text;
                    FormDataStorage.CreateUnit.Quantity = Convert.ToInt32(unitForm.textBoxUnitData2.Value);
                    //FormDataStorage.CreateUnit.PriceImport = float.Parse(unitForm.textBoxUnitData3.Text);
                    if (float.TryParse(unitForm.textBoxUnitData3.Text, out float priceImport))
                    {
                        FormDataStorage.CreateUnit.PriceImport = priceImport;
                    }
                    else
                    {
                        // Xử lý lỗi hoặc thông báo cho người dùng
                    }
                    //FormDataStorage.CreateUnit.PriceExport = float.Parse(unitForm.textBoxUnitData4.Text);
                    if (float.TryParse(unitForm.textBoxUnitData4.Text, out float priceImport1))
                    {
                        FormDataStorage.CreateUnit.PriceExport = priceImport1;
                    }
                    else
                    {
                        // Xử lý lỗi hoặc thông báo cho người dùng
                    }
                }
                else if (currentForm is ManageProducts.frmCreateSupplier)
                {
                    var supplierForm = (ManageProducts.frmCreateSupplier)currentForm;
                    FormDataStorage.CreateSupplier.ProductData = supplierForm.textBoxSupplierData.Text;
                    FormDataStorage.CreateSupplier.Address = supplierForm.textBoxSupplierData1.Text;
                    FormDataStorage.CreateSupplier.note = supplierForm.textBoxSupplierData2.Text;
                }
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            SaveCurrentFormData();
            formIndex++;
            if (formIndex >= formTypes.Length)
            {
                formIndex = 0;
            }

            LoadForm();


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveCurrentFormData();
            formIndex--;
            if (formIndex < 0)
            {
                formIndex = formTypes.Length - 1;
            }

            LoadForm();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                currentForm.Dispose();
                currentForm = null;
            }

            currentForm = (Form)Activator.CreateInstance(formTypes[formIndex]);
            u.openChildForm(currentForm, tableLayoutPanel1);

            if (formIndex == 0)
            {
                pictureBox1.Visible = false;
                BtAdd.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                BtAdd.Visible = false;
            }

            if (formIndex == formTypes.Length - 1)
            {
                pbNext.Visible = false;
                BtAdd.Visible = true;
            }
            else
            {
                pbNext.Visible = true;
                BtAdd.Visible = false;
            }


            RestoreFormData();
        }
        private void RestoreFormData()
        {

            if (currentForm != null)
            {
                if (currentForm is ManageProducts.frmCreateProduct)
                {
                    var productForm = (ManageProducts.frmCreateProduct)currentForm;
                    productForm.TextBoxProductData.Text = FormDataStorage.CreateProductData.ProductData;
                    productForm.TextBoxProductData7.Text = FormDataStorage.CreateProductData.Status;
                    productForm.TextBoxProductData1.Text = FormDataStorage.CreateProductData.Type;
                    productForm.TextBoxProductData2.Text = FormDataStorage.CreateProductData.IDsup;
                    productForm.TextBoxProductData4.Value = FormDataStorage.CreateProductData.MFG != DateTime.MinValue ? FormDataStorage.CreateProductData.MFG : DateTime.Today;
                    productForm.TextBoxProductData3.Value = FormDataStorage.CreateProductData.EXP != DateTime.MinValue ? FormDataStorage.CreateProductData.EXP : DateTime.Today;
                    productForm.TextBoxProductData5.Value = FormDataStorage.CreateProductData.DateImport != DateTime.MinValue ? FormDataStorage.CreateProductData.DateImport : DateTime.Today;
                    productForm.TextBoxProductData9.Text = FormDataStorage.CreateProductData.Path;
                    productForm.TextBoxProductData8.Image = FormDataStorage.CreateProductData.picture;
                    productForm.UpdateIDsupComboBox();

                }
                else if (currentForm is ManageProducts.frmCreateUnit)
                {
                    var unitForm = (ManageProducts.frmCreateUnit)currentForm;
                    unitForm.textBoxUnitData.SelectedItem = FormDataStorage.CreateUnit.NameUnit;
                    unitForm.textBoxUnitData1.Text = FormDataStorage.CreateUnit.SkuProduct;
                    unitForm.textBoxUnitData2.Value = FormDataStorage.CreateUnit.Quantity;
                    unitForm.textBoxUnitData3.Text = FormDataStorage.CreateUnit.PriceImport.ToString();
                    unitForm.textBoxUnitData4.Text = FormDataStorage.CreateUnit.PriceExport.ToString();
                    unitForm.UpdateSKUComboBox();

                }
                else if (currentForm is ManageProducts.frmCreateSupplier)
                {
                    var supplierForm = (ManageProducts.frmCreateSupplier)currentForm;
                    supplierForm.textBoxSupplierData.Text = FormDataStorage.CreateSupplier.ProductData;
                    supplierForm.textBoxSupplierData1.Text = FormDataStorage.CreateSupplier.Address;
                    supplierForm.textBoxSupplierData2.Text = FormDataStorage.CreateSupplier.note;


                }
            }
        }

        private void frmCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDataStorage.CreateProductData.Path = null;
            FormDataStorage.CreateProductData.ProductData = null;
            FormDataStorage.CreateProductData.Status = null;
            FormDataStorage.CreateProductData.Type = null;
            FormDataStorage.CreateProductData.IDsup = null;
            FormDataStorage.CreateProductData.MFG = default;
            FormDataStorage.CreateProductData.EXP = default;
            FormDataStorage.CreateProductData.DateImport = default;
            FormDataStorage.CreateProductData.picture = default;

            FormDataStorage.CreateUnit.SkuProduct = null;
            FormDataStorage.CreateUnit.NameUnit = null;
            FormDataStorage.CreateUnit.Quantity = 0;
            FormDataStorage.CreateUnit.PriceImport = default;
            FormDataStorage.CreateUnit.PriceExport = default;

            FormDataStorage.CreateSupplier.ProductData = null;
            FormDataStorage.CreateSupplier.note = null;
            FormDataStorage.CreateSupplier.Address = null;

        }
        public string autoIDSup(string id)
        {
            string prefix = id.Substring(0, 2);
            int number = int.Parse(id.Substring(2));
            number++;
            string nextID = prefix + number.ToString().PadLeft(2, '0');

            return nextID;
        }
        public string autoSKU(string id)
        {
            string prefix = id.Substring(0, 1);
            int number = int.Parse(id.Substring(1));
            number++;
            string nextID = prefix + number.ToString().PadLeft(2, '0');

            return nextID;
        }

        public string ImageToBase64(string path)
        {
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
        public string autoIDUnit(string id)
        {
            string prefix = id.Substring(0, 3);
            int number = int.Parse(id.Substring(1));
            number++;
            string nextID = prefix + number.ToString().PadLeft(2, '0');

            return nextID;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormDataStorage.CreateProductData.Path = "";
            FormDataStorage.CreateProductData.ProductData = "";
            FormDataStorage.CreateProductData.Status = null;
            FormDataStorage.CreateProductData.Type = null;
            FormDataStorage.CreateProductData.IDsup = null;
            FormDataStorage.CreateProductData.MFG = default;
            FormDataStorage.CreateProductData.EXP = default;
            FormDataStorage.CreateProductData.DateImport = default;
            FormDataStorage.CreateProductData.picture = default;


            FormDataStorage.CreateUnit.NameUnit = default;
            FormDataStorage.CreateUnit.Quantity = 0;
            FormDataStorage.CreateUnit.PriceImport = default;
            FormDataStorage.CreateUnit.PriceExport = default;
            //if (currentForm != null)
            //{
            //    if (currentForm is ManageProducts.frmCreateUnit)
            //    {
            //        var unitForm = (ManageProducts.frmCreateUnit)currentForm;
            //        unitForm.UpdateSKUComboBox();
            //    }
            //}
            FormDataStorage.CreateUnit.SkuProduct = null;

            FormDataStorage.CreateSupplier.ProductData = "";
            FormDataStorage.CreateSupplier.note = "";
            FormDataStorage.CreateSupplier.Address = "";

        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            _AddPro = new ProductService();
            _AddSup = new SupplierServices();
            _AddUnit = new UnitService();


            if (FormDataStorage.CreateSupplier.ProductData == "" && FormDataStorage.CreateSupplier.note == ""
                && FormDataStorage.CreateSupplier.Address == "" && FormDataStorage.CreateProductData.ProductData == ""
                && FormDataStorage.CreateProductData.Path == "")
            {
                Unit newUnit = new Unit();
                _IdUnit = new UnitServices();
                _SKULast = new ProductService();
                var _autoid2 = _IdUnit.GetAll().ToList().Select(c => c.IdUnit).Max();
                string nextid = autoIDUnit(_autoid2);
                newUnit.IdUnit = nextid;

                if (currentForm != null)
                {
                    if (currentForm is ManageProducts.frmCreateUnit)
                    {
                        var supplierunit = (ManageProducts.frmCreateUnit)currentForm;
                        var lastSKU = _SKULast.GetAll().Where(p => p.NameProduct == supplierunit.textBoxUnitData1.Text).FirstOrDefault();
                        newUnit.Sku = lastSKU.Sku;
                        
                        double temp = Convert.ToDouble(supplierunit.textBoxUnitData4.Text);
                        double temp1 = Convert.ToDouble(supplierunit.textBoxUnitData3.Text);
                        if (supplierunit.textBoxUnitData4.Text == "" ||
                            supplierunit.textBoxUnitData3.Text == "" ||
                            !double.TryParse(supplierunit.textBoxUnitData4.Text = temp.ToString("#,###"), out double price) ||
                            price < 0 ||
                            !double.TryParse(supplierunit.textBoxUnitData3.Text = temp1.ToString("#,###"), out double price1) ||
                            price1 < 0 ||
                            supplierunit.textBoxUnitData.Text == "")
                        {
                            MessageBox.Show("Not Be Empty or Invalid Value");
                        }
                        else
                        {
                            newUnit.UnitName = supplierunit.textBoxUnitData.Text;
                            newUnit.QuantityUnit = Convert.ToInt32(supplierunit.textBoxUnitData2.Value);
                            newUnit.PriceExport = price;
                            newUnit.PriceImport = price1;
                            _AddUnit.Create(newUnit);
                            MessageBox.Show("Data added successfully!");
                            button2_Click(sender, e);
                            if (currentForm != null)
                            {
                                if (currentForm is ManageProducts.frmCreateSupplier)
                                {
                                    var supplierForm1 = (ManageProducts.frmCreateSupplier)currentForm;
                                    supplierForm1.Clear_Click(sender, e);
                                }
                                else if (currentForm is ManageProducts.frmCreateProduct)
                                {
                                    var productForm1 = (ManageProducts.frmCreateProduct)currentForm;
                                    productForm1.Clear_Click(sender, e);
                                }
                                else if (currentForm is ManageProducts.frmCreateUnit)
                                {
                                    var unitForm1 = (ManageProducts.frmCreateUnit)currentForm;
                                    unitForm1.btClear_Click(sender, e);
                                    unitForm1.loadUnit(sender, e);
                                }
                            }
                        }

                    }
                }

            }
            else if (FormDataStorage.CreateSupplier.ProductData == "" && FormDataStorage.CreateSupplier.note == ""
                && FormDataStorage.CreateSupplier.Address == "")
            {
                Product newProduct = new Product();
                _SKU = new ProductService();
                _idSuplast = new SupplierServices();
                var lastSUp = _idSuplast.GetAll().Where(c => c.NameSupplier == FormDataStorage.CreateProductData.IDsup).FirstOrDefault();
                //var _lastSupId = _idSup.GetAll().ToList().Select(c => c.IdSupplier).Max();
                var _autoID1 = _SKU.GetAll().ToList().Select(c => c.Sku).Max();
                string nextID1 = autoSKU(_autoID1);
                newProduct.Sku = nextID1;
                
                if (FormDataStorage.CreateProductData.Status == "Availability")
                {
                    newProduct.StatusP = true;
                }
                else
                {
                    newProduct.StatusP = false;
                }
                newProduct.IdSupplier = lastSUp.IdSupplier;

                newProduct.Mfg = FormDataStorage.CreateProductData.MFG;
                //if (FormDataStorage.CreateProductData.MFG < FormDataStorage.CreateProductData.EXP)
                //{
                //    newProduct.Exp = FormDataStorage.CreateProductData.EXP;
                //}
                ////newProduct.Exp = FormDataStorage.CreateProductData.EXP;
                //else
                //{
                //    MessageBox.Show("EXP must be greater than MFG");
                //}
                newProduct.DateImport = FormDataStorage.CreateProductData.DateImport;
                //if (FormDataStorage.CreateProductData.Path == "")
                //{
                //    MessageBox.Show("Not Blank");
                //}
                //else
                //{
                //    newProduct.PictureProduct = ImageToBase64(FormDataStorage.CreateProductData.Path);
                //}

                // Thực hiện thêm dữ liệu vào bảng Product

                // Thêm dữ liệu vào bảng Unit

                Unit newUnit = new Unit();
                _IdUnit = new UnitServices();
                _SKULast = new ProductService();
                //var lastSKU = _SKULast.GetAll().ToList().Select(c => c.Sku).Max();
                var _autoid2 = _IdUnit.GetAll().ToList().Select(c => c.IdUnit).Max();
                string nextid = autoIDUnit(_autoid2);
                newUnit.IdUnit = nextid;
                //newUnit.Sku = lastSKU;
                if (currentForm != null)
                {
                    if (currentForm is ManageProducts.frmCreateUnit)
                    {
                        var supplierunit = (ManageProducts.frmCreateUnit)currentForm;
                        
                        double temp = Convert.ToDouble(supplierunit.textBoxUnitData4.Text);
                        double temp1 = Convert.ToDouble(supplierunit.textBoxUnitData3.Text);
                        
                        if (supplierunit.textBoxUnitData4.Text == "" ||
                           supplierunit.textBoxUnitData3.Text == "" ||
                           !double.TryParse(supplierunit.textBoxUnitData4.Text = temp.ToString("#,###"), out double price) ||
                           price < 0 ||
                           !double.TryParse(supplierunit.textBoxUnitData3.Text = temp1.ToString("#,###"), out double price1) ||
                           price1 < 0 ||
                            supplierunit.textBoxUnitData.Text == "")
                        {
                            MessageBox.Show("Not Be Empty or Invalid Value");
                        }
                        else if (FormDataStorage.CreateProductData.MFG > FormDataStorage.CreateProductData.EXP)
                        {
                            MessageBox.Show("EXP must be greater than MFG");
                        }
                        else if (FormDataStorage.CreateProductData.Path == "" || FormDataStorage.CreateProductData.Type == ""  ||
                            FormDataStorage.CreateProductData.ProductData=="")
                        {
                            MessageBox.Show("Not Blank");
                        }
                        else
                        {
                            newUnit.UnitName = supplierunit.textBoxUnitData.Text;
                            newProduct.ProductType = FormDataStorage.CreateProductData.Type;
                            newProduct.NameProduct = FormDataStorage.CreateProductData.ProductData;
                            newProduct.PictureProduct = ImageToBase64(FormDataStorage.CreateProductData.Path);
                            newProduct.Exp = FormDataStorage.CreateProductData.EXP;
                            newUnit.QuantityUnit = Convert.ToInt32(supplierunit.textBoxUnitData2.Value);
                            newUnit.PriceExport = price;
                            newUnit.PriceImport = price1;
                            _AddPro.Create(newProduct);
                            var lastSKU = _SKULast.GetAll().ToList().Select(c => c.Sku).Max();
                            newUnit.Sku = lastSKU;
                            _AddUnit.Create(newUnit);
                            MessageBox.Show("Data added successfully!");
                            button2_Click(sender, e);
                            if (currentForm != null)
                            {
                                if (currentForm is ManageProducts.frmCreateSupplier)
                                {
                                    var supplierForm1 = (ManageProducts.frmCreateSupplier)currentForm;
                                    supplierForm1.Clear_Click(sender, e);
                                }
                                else if (currentForm is ManageProducts.frmCreateProduct)
                                {
                                    var productForm1 = (ManageProducts.frmCreateProduct)currentForm;
                                    productForm1.Clear_Click(sender, e);
                                }
                                else if (currentForm is ManageProducts.frmCreateUnit)
                                {
                                    var unitForm1 = (ManageProducts.frmCreateUnit)currentForm;
                                    unitForm1.btClear_Click(sender, e);
                                    unitForm1.loadUnit(sender, e);
                                }
                            }
                        }
                    }
                }

            }
            else if (FormDataStorage.CreateSupplier.ProductData != "" && FormDataStorage.CreateSupplier.Address != ""
                && FormDataStorage.CreateSupplier.note != "")
            {
                //Thực hiện thêm dữ liệu vào bảng Supplier
                Supplier newSupplier = new Supplier();
                _idSup = new SupplierServices();
                var _autoID = _idSup.GetAll().ToList().Select(c => c.IdSupplier).Max();
                string nextID = autoIDSup(_autoID);
                newSupplier.IdSupplier = nextID;
                newSupplier.NameSupplier = FormDataStorage.CreateSupplier.ProductData;
                newSupplier.AddressSupplier = FormDataStorage.CreateSupplier.Address;
                newSupplier.Note = FormDataStorage.CreateSupplier.note;



                //Thêm dữ liệu vào bảng Product
                Product newProduct = new Product();
                _SKU = new ProductService();
                _idSuplast = new SupplierServices();
                var _lastSupId = _idSup.GetAll().ToList().Select(c => c.IdSupplier).Max();
                var _autoID1 = _SKU.GetAll().ToList().Select(c => c.Sku).Max();
                string nextID1 = autoSKU(_autoID1);
                newProduct.Sku = nextID1;
                //newProduct.ProductType = FormDataStorage.CreateProductData.Type;
                //newProduct.NameProduct = FormDataStorage.CreateProductData.ProductData;
                if (FormDataStorage.CreateProductData.Status == "Availability")
                {
                    newProduct.StatusP = true;
                }
                else
                {
                    newProduct.StatusP = false;
                }
                newProduct.IdSupplier = _lastSupId;
                newProduct.Mfg = FormDataStorage.CreateProductData.MFG;
                //newProduct.Exp = FormDataStorage.CreateProductData.EXP;
                //if (FormDataStorage.CreateProductData.MFG < FormDataStorage.CreateProductData.EXP)
                //{
                //    newProduct.Exp = FormDataStorage.CreateProductData.EXP;
                //}
                //else
                //{
                //    MessageBox.Show("EXP must be greater than MFG");
                //}
                newProduct.DateImport = FormDataStorage.CreateProductData.DateImport;
                //if (FormDataStorage.CreateProductData.Path == "")
                //{
                //    MessageBox.Show("Not Blank");
                //}
                //else
                //{
                //    newProduct.PictureProduct = ImageToBase64(FormDataStorage.CreateProductData.Path);
                //}
                // Thực hiện thêm dữ liệu vào bảng Product

                // Thêm dữ liệu vào bảng Unit

                Unit newUnit = new Unit();
                _IdUnit = new UnitServices();
                _SKULast = new ProductService();
                //var lastSKU = _SKULast.GetAll().ToList().Select(c => c.Sku).Max();
                var _autoid2 = _IdUnit.GetAll().ToList().Select(c => c.IdUnit).Max();
                string nextid = autoIDUnit(_autoid2);
                newUnit.IdUnit = nextid;
                //newUnit.Sku = lastSKU;
                if (currentForm != null)
                {
                    if (currentForm is ManageProducts.frmCreateUnit)
                    {
                        var supplierunit = (ManageProducts.frmCreateUnit)currentForm;
                        //newUnit.UnitName = supplierunit.textBoxUnitData.Text;
                        double temp = Convert.ToDouble(supplierunit.textBoxUnitData4.Text);
                        double temp1 = Convert.ToDouble(supplierunit.textBoxUnitData3.Text);
                        if (supplierunit.textBoxUnitData4.Text == "" ||
                           supplierunit.textBoxUnitData3.Text == "" ||
                           !double.TryParse(supplierunit.textBoxUnitData4.Text = temp.ToString("#,###"), out double price) ||
                           price < 0 ||
                           !double.TryParse(supplierunit.textBoxUnitData3.Text = temp1.ToString("#,###"), out double price1) ||
                           price1 < 0 ||
                               supplierunit.textBoxUnitData.Text =="")
                        {
                            MessageBox.Show("Not Be Empty or Invalid Value");
                        }
                        else if (FormDataStorage.CreateProductData.MFG > FormDataStorage.CreateProductData.EXP)
                        {
                            MessageBox.Show("EXP must be greater than MFG");
                        }
                        else if (FormDataStorage.CreateProductData.Path == "" || FormDataStorage.CreateProductData.Type == "" ||
                            FormDataStorage.CreateProductData.ProductData=="")
                        {
                            MessageBox.Show("Not Blank");
                        }
                        else
                        {
                            newProduct.ProductType = FormDataStorage.CreateProductData.Type;
                            newProduct.NameProduct = FormDataStorage.CreateProductData.ProductData;
                            newUnit.UnitName = supplierunit.textBoxUnitData.Text;
                            newProduct.PictureProduct = ImageToBase64(FormDataStorage.CreateProductData.Path);
                            newProduct.Exp = FormDataStorage.CreateProductData.EXP;
                            newUnit.QuantityUnit = Convert.ToInt32(supplierunit.textBoxUnitData2.Value);
                            newUnit.PriceExport = price;
                            newUnit.PriceImport = price1;
                            _AddSup.Create(newSupplier);
                            _AddPro.Create(newProduct);
                            var lastSKU = _SKULast.GetAll().ToList().Select(c => c.Sku).Max();
                            newUnit.Sku = lastSKU;
                            
                            _AddUnit.Create(newUnit);
                            MessageBox.Show("Data added successfully!");
                            button2_Click(sender, e);
                            if (currentForm != null)
                            {
                                if (currentForm is ManageProducts.frmCreateSupplier)
                                {
                                    var supplierForm1 = (ManageProducts.frmCreateSupplier)currentForm;
                                    supplierForm1.Clear_Click(sender, e);
                                }
                                else if (currentForm is ManageProducts.frmCreateProduct)
                                {
                                    var productForm1 = (ManageProducts.frmCreateProduct)currentForm;
                                    productForm1.Clear_Click(sender, e);
                                }
                                else if (currentForm is ManageProducts.frmCreateUnit)
                                {
                                    var unitForm1 = (ManageProducts.frmCreateUnit)currentForm;
                                    unitForm1.btClear_Click(sender, e);
                                    unitForm1.loadUnit(sender, e);
                                }
                            }
                        }
                    }
                }



            }
            else
            {
                MessageBox.Show("Not Created!");
            }



        }


    }
}
