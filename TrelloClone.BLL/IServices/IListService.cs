using TrelloClone.BLL.DTOs.Lists;

namespace TrelloClone.BLL.IServices;

public interface IListService
{
    Task<List<ListDto>>  GetByBoardAsync(int boardId);
    Task<int> CreateListAsync(int boardId, CreateListDto dto);
}