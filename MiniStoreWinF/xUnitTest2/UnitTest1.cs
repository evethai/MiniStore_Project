using MiniStoreWinF.ManageSalary;
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


namespace xUnitTesting
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

        [InlineData(3900000, 25150000)]//test case wrong

        public void Tax_CalculateProgressiveFocusOnlySalary(double salary, double expected)
        {
            //Arrange
            CalculationAuto cal = new CalculationAuto();

            // Act
            var actual = cal.Tax("SE12", DateTime.Now.AddMonths(-2), salary);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}