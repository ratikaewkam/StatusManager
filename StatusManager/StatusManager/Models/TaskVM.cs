using System.ComponentModel.DataAnnotations;

namespace StatusManager.Models
{
    public class TaskVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
