using Microsoft.EntityFrameworkCore;
using TrelloClone.DAL.DBContext;

namespace TrelloClone.DAL.Entities
{
    public class Board
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        //FK
        public int UserId { get; set; }
        
        // Navigation
        public User user { get; set; }
        public ICollection<CardList> CardLists { get; set; }
    }
}