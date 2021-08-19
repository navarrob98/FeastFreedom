using System;
using System.ComponentModel.DataAnnotations;

namespace FeastFreedom.Models
{
    public class Regular_Users
    {
        [Key, Required]
        public int UserID { get; set; }
        [Required, MaxLength(50)]
        public String FirstName { get; set; }
        [Required, MaxLength(50)]
        public String LastName { get; set; }
        [Required, MaxLength(50)]
        public String Email { get; set; }
        [Required, MaxLength(10)]
        public String Password { get; set; }
     
        [Required, MaxLength(50)]
        public String Answer1 { get; set; }
        
        [Required, MaxLength(50)]
        public String Answer2 { get; set; }

        public int Question1ID { get; set; }
        public int Question2ID { get; set; }
        public KitchenUsers SecurityQuestions { get; set; }

        
        
    }
}
