using TrelloClone.DAL.Entities;

namespace TrelloClone.DAL
{
    public class Card
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }

        // FK
        public int CardListId { get; set; }
        public CardList CardListList { get; set; }
    }
};

