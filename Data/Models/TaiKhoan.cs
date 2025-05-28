using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class TaiKhoan
    {
        [Key]
        public Guid taikhoanId { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$")]
        public string username {  get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string hovaten {  get; set; }
        [Required]
        public string gioitinh {  get; set; }
        [Required]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string sdt {  get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public DateTime ngaysinh { get; set; }
        public DateTime ngaytaotaikhoan {  get; set; }
        public int trangthai { get; set; }
    }
}
