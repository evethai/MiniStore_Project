using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class HeSoTinhLuong
    {
        public string Id { get; set; }
        public double? Bhxh { get; set; }
        public double? Bhyt { get; set; }
        public double? Bhtn { get; set; }
        public double? GtgcBanthan { get; set; }
        public double? GtgcNpt { get; set; }
        public double? LuongToiThieu { get; set; }
        public double? MucBhToiDa { get; set; }
    }
}
