using TrelloClone.BLL.DTOs.Lists;

namespace TrelloClone.BLL.IServices;

public interface IListService
{
    Task<List<ListDto>>  GetByBoardAsync(Guid boardId);
    Task<Guid> CreateListAsync(Guid boardId, CreateListDto dto);
}