using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        /// <summary>
        /// Identity Column
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// How to define a command
        /// </summary>
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}