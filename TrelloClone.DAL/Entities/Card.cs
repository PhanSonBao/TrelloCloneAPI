using System.ComponentModel.DataAnnotations;

namespace TrelloClone.DAL.Entities
{
    public class Card
    {
        [Key]
        public int UID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }

        // FK
        public int CardListId { get; set; }
        public List ListList { get; set; }
    }
};

