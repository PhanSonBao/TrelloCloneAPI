using System.ComponentModel.DataAnnotations;

namespace TrelloClone.DAL.Entities
{
    public class List
    {
        [Key]
        public int UID { get; set; }
        public string Title { get; set; }
        public int Position { get; set; } // Để kéo thả reorder
        
        // FK
        public int BoardId { get; set; }
        
        //Navigation
        public Board Board { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}