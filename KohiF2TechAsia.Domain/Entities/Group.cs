using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KohiF2TechAsia.Domain.Entities
{
    public class Group : BaseEntity<int>
    {
        [Required]
        [StringLength(200)]
        public string GroupName { get; set; }

        public int DisplayOrder { get; set; }
    }
}
