namespace TrelloClone.BLL.DTOs;

public class CardListsDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Position { get; set; }
    public List<CardDto> Cards { get; set; } = new();
}