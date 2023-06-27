using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Database.Controllers
{
    public class Myutils
    {
        // Hàm tăng giá trị IdWorkSheet lên một đơn vị
        public static string IncrementIdWorkSheet(string lastIdWorkSheet)
        {
            if (string.IsNullOrEmpty(lastIdWorkSheet))
            {
                // Nếu không có IdWorkSheet trong cơ sở dữ liệu, bắt đầu từ WS001
                return "WS001";
            }

            // Tách số từ chuỗi IdWorkSheet cuối cùng
            string numberPart = lastIdWorkSheet.Substring(2); // Sửa từ 3 thành 2

            if (int.TryParse(numberPart, out int number))
            {
                // Tăng số lên một đơn vị
                number++;

                // Định dạng lại chuỗi IdWorkSheet
                string newNumberPart = number.ToString("D3"); // D3 đảm bảo số có 3 chữ số, ví dụ: 001, 002, ...

                // Kiểm tra nếu số mới vượt quá 999, trả về giá trị mặc định
                if (number > 999)
                {
                    return "WS001";
                }

                return "WS" + newNumberPart;
            }

            // Trường hợp không thể tách số từ chuỗi IdWorkSheet, trả về giá trị mặc định
            return "WS001";
        }



    }
}