using System;
using System.ComponentModel.DataAnnotations;

namespace FeastFreedom.Models
{
    public class SecurityQuestions
    {
        [Key, Required]
        public int QuestionID { get; set; }
        [Required]
        public String Question { get; set; }
    }
}
