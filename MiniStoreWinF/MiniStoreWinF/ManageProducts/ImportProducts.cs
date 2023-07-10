using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using System.Data;
using Repository.Models;
using Repository.Service;
using Microsoft.EntityFrameworkCore;

namespace MiniStoreWinF.ManageProducts
{
    public class ImportProducts
    {
        ProductService _Sku;
        public void ImportDataFromExcel(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Đọc dữ liệu từ file Excel
                    var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });

                    // Truy cập bảng "Product"  trong dataSet
                    var productsTable = dataSet.Tables["Product Data"];

                    using (var context = new MiniStoreContext())
                    {
                        //string lastID = context.Products.Select(p => p.Sku).Max();
                        //string prefix = lastID.Substring(0, 1);
                        //int count = int.Parse(lastID.Substring(1));
                        
                        // Import dữ liệu vào cơ sở dữ liệu
                        foreach (DataRow row in productsTable.Rows)
                        {
                            //count++;
                            //string nextId = prefix + count.ToString().PadLeft(2, '0');
                            var product = new Product
                            {
                                //Sku = nextId.ToString(),
                                Sku = row["SKU"].ToString(),
                                ProductType = row["ProductType"].ToString(),
                                NameProduct = row["NameProduct"].ToString(),
                                //QuantityProduct = int.Parse(row["QuantityProduct"].ToString()),
                                //PriceProduct = float.Parse(row["PriceProduct"].ToString()),
                                //PriceToOrders = float.Parse(row["PriceToOrders"].ToString()),

                                IdSupplier = row["IdSupplier"].ToString(),
                                //IdUnit = row["IdUnit"].ToString(),
                                //QuantityUnit = int.Parse(row["QuantityUnit"].ToString()),
                                //PriceUnit = float.Parse(row["PriceUnit"].ToString()),
                                //TotalPriceUnit = float.Parse(row["TotalPriceUnit"].ToString()),

                                Mfg = ConvertToDateTime(row["Mfg"]),
                                Exp = ConvertToDateTime(row["Exp"]),
                                DateImport = ConvertToDateTime(row["DateImport"]),
                                StatusP = Convert.ToBoolean(row["StatusP"]),

                                PictureProduct = ImageToBase64(row["PictureProduct"].ToString()),


                            };
                            var existingProduct = context.Products.Local.FirstOrDefault(p => p.Sku == product.Sku);
                            if (existingProduct != null)
                            {
                                context.Entry(existingProduct).State = EntityState.Detached;
                            }

                            context.Products.Add(product);


                        }
                        
                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();
                    
                    }
                }
            }
        }
        public void ImportDataFromExcelUnit(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Đọc dữ liệu từ file Excel
                    var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });

                    // Truy cập bảng "Product"  trong dataSet
                    var productsTable = dataSet.Tables["Unit Data"];

                    using (var context = new MiniStoreContext())
                    {
                        //autoID
                        string lastID = context.Units.Select(p => p.IdUnit).Max();
                        string prefix = lastID.Substring(0, 3);
                        int count = int.Parse(lastID.Substring(1));

                        // Import dữ liệu vào cơ sở dữ liệu
                        foreach (DataRow row in productsTable.Rows)
                        {
                            count++;
                            string nextId = prefix + count.ToString().PadLeft(2, '0');
                            var _unit = new Unit
                            {
                                IdUnit = nextId.ToString(),
                                Sku = row["Sku"].ToString(),
                                UnitName = row["UnitName"].ToString(),
                                QuantityUnit = int.Parse(row["QuantityUnit"].ToString()),
                                PriceImport = float.Parse(row["PriceImport"].ToString()),
                                PriceExport = float.Parse(row["PriceExport"].ToString()),
                            };
                            var existingProduct = context.Units.Local.FirstOrDefault(p => p.IdUnit == _unit.IdUnit);
                            if (existingProduct != null)
                            {
                                context.Entry(existingProduct).State = EntityState.Detached;
                            }

                            context.Units.Add(_unit);


                        }

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                    }
                }
            }
        }
        public void ImportDataFromExcelSupplier(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Đọc dữ liệu từ file Excel
                    var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });

                    // Truy cập bảng "Product"  trong dataSet
                    var productsTable = dataSet.Tables["Supplier Data"];

                    using (var context = new MiniStoreContext())
                    {
                        //autoID
                        //string lastID = context.Units.Select(p => p.IdUnit).Max();
                        //string prefix = lastID.Substring(0, 3);
                        //int count = int.Parse(lastID.Substring(1));

                        // Import dữ liệu vào cơ sở dữ liệu
                        foreach (DataRow row in productsTable.Rows)
                        {
                            //count++;
                            //string nextId = prefix + count.ToString().PadLeft(2, '0');
                            var _supplier = new Supplier
                            {
                                //IdUnit = nextId.ToString(),
                                IdSupplier = row["IDSupplier"].ToString(),
                                NameSupplier = row["NameSupplier"].ToString(),
                                AddressSupplier = row["Address"].ToString(),
                                Note = row["Note"].ToString(),
                            };
                            var existingProduct = context.Suppliers.Local.FirstOrDefault(p => p.IdSupplier == _supplier.IdSupplier);
                            if (existingProduct != null)
                            {
                                context.Entry(existingProduct).State = EntityState.Detached;
                            }

                            context.Suppliers.Add(_supplier);


                        }

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                    }
                }
            }
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
        private DateTime? ConvertToDateTime(object value)
        {
            if (value != null && DateTime.TryParse(value.ToString(), out DateTime result))
            {
                return result;
            }

            return null;
        }
        
    }
}
