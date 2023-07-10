using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF
{
    public static class FormDataStorage
    {
       
        public static string SupplierData { get; set; } // Dữ liệu tạm thời của frmCreateSupplier

        public static class CreateProductData
        {
            public static string ProductData { get; set; }
            public static string Type { get; set; }
            public static string IDsup { get; set; }
            public static DateTime MFG { get; set; }
            public static DateTime EXP { get; set; }
            public static DateTime DateImport { get; set; }
            
            public static string Status { get; set; }

            public static string Path { get; set; }

            public static Image picture { get; set; }
        }
        public static class CreateSupplier
        {
            public static string ProductData { get; set; }
            public static string Address { get; set; }
            public static string note { get; set;}
        }
        public static class CreateUnit
        {
            public static string SkuProduct { get;set; }
            public static string NameUnit { get; set; }
            public static int Quantity { get; set; }    
            public static float PriceImport { get; set; }
            public static float PriceExport { get; set;}
        }
    }
}
