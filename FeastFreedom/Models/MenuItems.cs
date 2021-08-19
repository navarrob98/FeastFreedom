using System;
using System.ComponentModel.DataAnnotations;

namespace FeastFreedom.Models
{
    public class MenuItems
    {
        [Key, Required]
        public int ItemID { get; set; }
        [Required, MaxLength(50)]
        public String Name { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public Boolean isVeg { get; set; }
        [Required]
        public float Price { get; set; }

        public int KitchenID { get; set; }
        public virtual KitchenUsers KitchenUsers { get; set; }
    }
}
