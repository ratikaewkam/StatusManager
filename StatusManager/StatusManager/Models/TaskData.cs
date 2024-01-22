using System.ComponentModel.DataAnnotations;

namespace StatusManager.Models
{
    public class TaskData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
