using System;
using System.ComponentModel.DataAnnotations;

namespace WebEval.Models
{
    public enum Gender
    {
        male,
        fale
    }

    public class Student
    {
        [Key]
        public int scoreId { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public Gender sex { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }


    }
}