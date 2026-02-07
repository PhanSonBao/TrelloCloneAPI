using TrelloClone.BLL.DTOs;
using TrelloClone.BLL.DTOs.Boards;

namespace TrelloClone.BLL.IServices;

public interface IBoardService
{
    Task<BoardDto> GetBoardAsync(Guid id);
    Task<Guid> CreateBoardAsync(CreateBoardDto dto);
}