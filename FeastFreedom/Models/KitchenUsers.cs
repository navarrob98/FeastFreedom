using System;
using System.ComponentModel.DataAnnotations;

namespace FeastFreedom.Models
{
    public class KitchenUsers
    {
        [Key, Required]
        public int KitchenID{ get; set; }
        [Required, MaxLength(50)]
        public String Name { get; set; }
        [Required, MaxLength(50)]
        public String Email { get; set; }
        [Required, MaxLength(10)]
        public String Password { get; set; }
        [Required]
        public Boolean isDelivery { get; set; }
        [Required]
        public Boolean isVeg { get; set; }
        [Required]
        public Boolean isOpenSunday { get; set; }
        [Required]
        public Boolean isOpenMonday { get; set; }
        [Required]
        public Boolean isOpenTuesday { get; set; }
        [Required]
        public Boolean isOpenWednesday { get; set; }
        [Required]
        public Boolean isOpenThursday { get; set; }
        [Required]
        public Boolean isOpenFriday { get; set; }
        [Required]
        public Boolean isOpenSaturday { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }


    }
}
