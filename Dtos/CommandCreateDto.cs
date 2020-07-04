using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        public string HowTo { get; set; }
        public string Line { get; set; }
        // [Required]
        public string Platform { get; set; }
    }
}