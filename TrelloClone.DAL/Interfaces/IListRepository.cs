using TrelloClone.DAL.Entities;

namespace TrelloClone.DAL.Interfaces;

public interface IListRepository
{
    Task<List<List>> GetByBoardIdAsync(int boardId);
    Task AddAsync(List list);
    Task SaveChangesAsync();
}