using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        // [Key]
        public int Id { get; set; } // Key for the diary entry
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}