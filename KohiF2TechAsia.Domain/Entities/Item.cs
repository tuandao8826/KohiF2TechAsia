using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KohiF2TechAsia.Domain.Entities
{
    public class Item : BaseEntity<int>
    {
        [Required]
        [StringLength(200)]
        public string ItemUKName { get; set; }

        [StringLength(200)]
        public string ItemVNName { get; set; }

        [Required]
        [StringLength(200)]
        public string UomName { get; set; } // Đơn vị đo lường của sản phẩm.

        [StringLength(200)]
        public string ItemUrlImage { get; set; }
        public int ItemDisplayOrder { get; set; } // Thứ tự hiển thị của sản phẩm trên trang web
        public decimal ItemPriceInclTax { get; set; } // Giá bao gồm thuế
        public decimal ItemPrice { get; set; } // Giá không bao gồm thuế
        public string CurName { get; set; } // Đơn vị tiền
        public int GroupID { get; set; } 
        public int OrderedQuantity { get; set; }
    }
}
