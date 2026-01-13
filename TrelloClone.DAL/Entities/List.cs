using System;

namespace TrelloClone.DAL.Entities
{
    public class List
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Position { get; set; } // Để kéo thả reorder
        
        // FK
        public int BoardId { get; set; }
        
        //Navigation
        public Board Board { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}