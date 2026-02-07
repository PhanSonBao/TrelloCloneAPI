using System.ComponentModel.DataAnnotations;

namespace TrelloClone.DAL.Entities
{
    public class Card
    {
        [Key]
        public Guid UID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }

        // FK
        public Card ListId { get; set; }
        public List List { get; set; }
    }
};

