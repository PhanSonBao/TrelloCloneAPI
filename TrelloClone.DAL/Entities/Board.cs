using System.ComponentModel.DataAnnotations;

namespace TrelloClone.DAL.Entities
{
    public class Board
    {
        [Key]
        public Guid UID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        //FK
        public Guid UserId { get; set; }
        
        // Navigation
        public User user { get; set; }
        public ICollection<List> Lists { get; set; }
    }
}