using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public enum State
    {
        approved,
        reprobate
    }


    public class Score
    {
        [Required]
        public string matter { get; set; }
        [Required]
        [Range (0,100)]
        public int scorest { get; set; }
        [Required]
        public State situation { get; set; }

    }
}