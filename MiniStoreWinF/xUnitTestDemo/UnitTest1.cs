using MiniStoreWinF.ManageSalary;
using MiniStoreWinF.ManageEmployees;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xunit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;
using MiniStoreWinF.ManageWorkSheets;
using MiniStoreWinF;

namespace xUnitTestDemo
{
    public class UnitTest1
    {
        //Test Tax function
        //Test case #1: check calculate tax function by attribute [Fact]
        //Procedures:
        //          1. Given data to CalculationAuto.Tax
        //          2. execute CalculationAuto.Tax
        //Expected value
        //          Give data(SQL server) in function must  be return 0
        //          Expected value  = 0
        [Trait("Tax", "Fact")]
        [Fact]
        public void Tax_CalculateTaxByDataInTable()
        {
            //Arrange
            CalculationAuto cal = new CalculationAuto();

            // Act
            var actual = cal.Tax("SE12", new DateTime(2023, 05, 01), 3900000);

            // Assert
            Assert.Equal(0, actual);
        }

        //Test case #2:check calculate tax function by DDT 
        //Procedures:
        //          1. Given data to CalculationAuto.Tax
        //          1.1 Take list data(SQL server) 
        //          1.2 Push list data into test function
        //          2. execute CalculationAuto.Tax
        //Expected value
        //          Give data(SQL server) in function must  be return {}
        //          Expected value for each Employee in May {}
        public static IEnumerable<object[]> TestData()
        {
            SalaryService _salaryService = new SalaryService();
            var list = _salaryService.GetAll().Where(p => p.DateImonth.Month == DateTime.Now.AddMonths(-2).Month).ToList();
            foreach (var item in list)
            {
                yield return new object[] { item.IdEmp, item.DateImonth, item.TotalSalary, item.Tax };
            }
        }
        [Trait("Tax", "DDT_MemberData")]
        [Theory]
        [MemberData(nameof(TestData))]
        public void Tax_DDT_CalculateTaxForSalaryFocusAllDataInTable(string id, DateTime time, double salary, double expected)
        {
            //Arrange
            CalculationAuto cal = new CalculationAuto();

            // Act
            var actual = cal.Tax(id, time, salary);

            // Assert
            Assert.Equal(expected, actual);
        }

        //test case #3: check calculate tax function by DDT and Progressive
        //because data in table sql not enough to test all case
        //Procedures:
        //          1. Given data to CalculationAuto.Tax, only focus Salary 
        //          2. execute CalculationAuto.Tax
        //Expected value
        //          Give data(SQL server) in function must  be return {}
        //          Expected value for each Employee in May {}
        [Trait("Tax", "DDT_InlineData")]
        [Theory]
        [InlineData(3900000, 0)]//not tax
        [InlineData(14000000, 700000)]//0-5m
        [InlineData(18000000, 1550000)]//5-10m
        [InlineData(25000000, 3000000)]//10-18m
        [InlineData(30000000, 4350000)]//18-32m
        [InlineData(45000000, 8000000)]//32-52m
        [InlineData(65000000, 13650000)]//52-80m
        [InlineData(100000000, 25150000)]//>80

        //[InlineData(3900000, 25150000)]//test case wrong

        public void Tax_CalculateProgressiveFocusOnlySalary(double salary, double expected)
        {
            //Arrange
            CalculationAuto cal = new CalculationAuto();

            // Act
            var actual = cal.Tax("SE12", DateTime.Now.AddMonths(-2), salary);

            // Assert
            Assert.Equal(expected, actual);
        }
        //test case #4: check convert from String to Int and Throw FormatException
        //Procedures:
        //          1. Given a String 
        //          2. execute Convert to Int
        //Expected value
        //          Give data in function must  be return FormatException
        [Fact]

        public void TestAutoIDThrownArgumentOutOfRangeException()
        {
            //// arrange
            //string numberstring = "This is not an integer type";

            //// act & assert
            //Assert.Throws<FormatException>(() => Convert.ToInt32(numberstring));
            Validation val = new Validation();
            Assert.Throws<ArgumentOutOfRangeException>(() => val.autoID("SE1", "SE"));
        }
        //test case #5: check calculate DateOfMonth function by DDT and Progressive
        //because data in table not enough to test all case
        //Procedures:
        //          1. Given data to DayOfMonth, only focus Month 
        //          2. Execute frmRegisterWorkSheet.DayOfMonths
        //Expected value
        //          Give data(Date Time) in function must be return {}
        //          ArgumentException value
        [Theory]
        [InlineData(13)]
        [InlineData(0)]
        [InlineData(null)]
        /*[InlineData(12)] */   // actual return 31  
        public void CheckDateOfMonthException(int date)
        {
            frmRegisterWorksheet _frmRegisterWorksheet = new frmRegisterWorksheet();
            Assert.Throws<ArgumentException>(() => _frmRegisterWorksheet.DayOfMonths(DateTime.Now, date));
        }
        //test case #6: check calculate DateOfMonth function 
        //Procedures:
        //          1. Given data to DayOfMonth, only focus Month 
        //          2. Execute frmRegisterWorkSheet.DayOfMonths
        //Expected value
        //          Give data(Datetime.Now) in function must be return {}
        //          Expected: 21, Actual 31
        [Fact]
        public void DateOfMonthCheckDateTimeNowHasManyDate()
        {
            frmRegisterWorksheet _frmRegisterWorksheet = new frmRegisterWorksheet();

            int actual = _frmRegisterWorksheet.DayOfMonth(DateTime.Now);

            Assert.Equal(21, actual);
        }


    }
    //[Collection("1")]
    //public class TestClass1
    //{
    //    [Fact]
    //    public void Test1()
    //    {
    //        Thread.Sleep(3000);
    //    }
    //}
    //[Collection("2")]
    //public class TestClass2
    //{
    //    [Fact]
    //    public void Test2()
    //    {
    //        Thread.Sleep(5000);
    //    }
    //}
    //[Collection("3")]
    //public class TestClass3
    //{
    //    [Fact]
    //    public void Test3()
    //    {
    //        Thread.Sleep(3000);
    //    }
    //}
    //[Collection("4")]
    //public class TestClass4
    //{

    //    [Fact]
    //    public void Test4()
    //    {
    //        Thread.Sleep(5000);
    //    }
    //}






}
