using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Castle.MicroKernel.SubSystems.Conversion;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicTahp.Models
{
    public class Music
    {
        public int Id { get; set; }
        [Display(Name = "Tên Truyện")]
        [StringLength(60, MinimumLength = 3)]
        [Required]

        public string Tentruyen { get; set; }
        [Display(Name = "Loại truyện")]
        public string CaSi { get; set; }
        [Display(Name = "Thể Loại")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]

        public string TheLoai { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Ngày Bán")]
        public DateTime NgayBan { get; set; }
        [Display(Name = "Giá")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Trạng Thái")]
        [Required]
        public string TrangThai { get; set; }

    }
}
