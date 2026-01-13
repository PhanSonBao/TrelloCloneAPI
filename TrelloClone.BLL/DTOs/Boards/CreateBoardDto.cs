namespace TrelloClone.BLL.DTOs.Boards;

public class CreateBoardDto
{
    public string Title { get; set; } = string.Empty;
    public int  UserId { get; set; }
}