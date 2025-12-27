namespace TrelloClone.BLL.DTOs;

public class BoardDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; }
    public int UserId { get; set; }
    public List<CardListsDto> CardLists { get; set; } = new();
}