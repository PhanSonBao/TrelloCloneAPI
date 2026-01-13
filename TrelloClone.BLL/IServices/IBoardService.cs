using TrelloClone.BLL.DTOs;
using TrelloClone.BLL.DTOs.Boards;

namespace TrelloClone.BLL.IServices;

public interface IBoardService
{
    Task<BoardDto> GetBoardAsync(int id);
    Task<int> CreateBoardAsync(CreateBoardDto dto);
}