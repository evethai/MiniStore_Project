using MiniStoreWinF.DashBoard;
using MiniStoreWinF.Manage_Voucher;
using MiniStoreWinF.ManageEmployees;
using MiniStoreWinF.ManageProducts;
using MiniStoreWinF.ManageSalary;
using MiniStoreWinF.ManageWorkSheet;
using MiniStoreWinF.OrdersProducts;

namespace MiniStoreWinF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {     
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}