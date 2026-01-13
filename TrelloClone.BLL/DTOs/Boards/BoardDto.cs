using TrelloClone.BLL.DTOs.Lists;

namespace TrelloClone.BLL.DTOs.Boards;

public class BoardDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public int UserId { get; set; }
    public List<ListDto> Lists { get; set; } = new();
}