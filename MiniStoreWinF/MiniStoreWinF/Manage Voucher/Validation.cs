using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF.Manage_Voucher
{
    public class Validation : ServiceMiniStore<Voucher>
    {
        MiniStoreContext _context;
        DbSet<Voucher> _voucher;
        DbSet<CodeVoucher> _codeVoucher;
        public Validation()
        {
            _context = new MiniStoreContext();
            _voucher = _context.Set<Voucher>();
            _codeVoucher = _context.Set<CodeVoucher>();
        }
        public Form currentFormChild;
        public void openChildForm(Form childForm, Panel p)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;//đặt thuộc tính cho form con không được hiển thị độc lập
            childForm.FormBorderStyle = FormBorderStyle.None;//tắt đường viền tắt các nút thu nhỏ mở rộng hay đóng form con
            childForm.Dock = DockStyle.Fill;//form con lấp đầy panel body
            p.Controls.Add(childForm);//thêm form con vào panel body
            p.Tag = childForm;//gán form con cho thuộc tính tag của panel để lưu trử thông tin form con
            childForm.BringToFront();//ĐƯA form con ra trước trong các điều khiển panel
            childForm.Show();//hiện thị nó 
        }
        public List<Voucher> GetName(string name)
        {
            var records = _voucher.Where(entity => entity.Name.Contains(name)).ToList();

            return records;
        }
        public void AddNewVoucher(Voucher voucher)
        {
            var lastRecord = _voucher.OrderByDescending(record => record.IdVoucher).FirstOrDefault();
            if (lastRecord != null)
            {
                voucher.IdVoucher = autoID(lastRecord.IdVoucher);
            }
            else
            {
                voucher.IdVoucher = autoID("VO000");



            }
            _voucher.Add(voucher);
            _context.SaveChanges();
        }
        public string autoID(string id)
        {
            //VOXXX
            string result = "";
            int cutID = int.Parse(id.Substring(2, 3));
            cutID++;
            int digits = 3;
            string prefix = "VO";

            // Convert the current ID to string with leading zeros
            string idString = cutID.ToString().PadLeft(digits, '0');
            result = prefix + idString;

            // Combine the prefix and the formatted ID
            return result;

        }
        public void AddNewEachVoucher(CodeVoucher voucher)
        {
            voucher.Id = GenerateRandomString(5);
            _codeVoucher.Add(voucher);
            _context.SaveChanges();
        }


        public string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();

            //Check if duplicated
            bool[] usedIndices = new bool[chars.Length];

            while (stringBuilder.Length < length)
            {
                int randomIndex = random.Next(0, chars.Length);

                // If duplicated --> continue random until not duplicated
                if (usedIndices[randomIndex])
                {
                    continue;
                }

                usedIndices[randomIndex] = true;
                char randomChar = chars[randomIndex];
                stringBuilder.Append(randomChar);
            }

            return stringBuilder.ToString();
        }

    }
}
