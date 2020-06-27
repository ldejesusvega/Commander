namespace Commander.Models
{
    public class Command
    {
        /// <summary>
        /// Identity Column
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// How to define a command
        /// </summary>
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
    }
}