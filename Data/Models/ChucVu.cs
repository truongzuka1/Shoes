﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class ChucVu
    {
        [Key]
        public Guid ChucVuId { get; set; }

        [Required(ErrorMessage = "Tên chức vụ là bắt buộc")]
        [StringLength(50, ErrorMessage = "Tên chức vụ không được vượt quá 50 ký tự")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Tên chức vụ chỉ được chứa chữ cái và khoảng trắng")]
        public string TenChucVu { get; set; }

        [StringLength(200, ErrorMessage = "Mô tả không được vượt quá 200 ký tự")]
        public string MotaChucVu { get; set; }

        [Required]
        public int TrangThai { get; set; }
    }

}
