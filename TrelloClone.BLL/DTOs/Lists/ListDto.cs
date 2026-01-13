using TrelloClone.BLL.DTOs.Cards;

namespace TrelloClone.BLL.DTOs.Lists;

public class ListDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Position { get; set; }
    public List<CardDto> Cards { get; set; } = new();
}