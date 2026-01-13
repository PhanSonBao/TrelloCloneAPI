using Microsoft.EntityFrameworkCore;
using TrelloClone.DAL.DBContext;
using TrelloClone.DAL.Entities;
using TrelloClone.DAL.Interfaces;

namespace TrelloClone.DAL.Repositories;

public class ListRepository : IListRepository
{
    private readonly AppDbContext _dbContext;

    public ListRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<List>> GetByBoardIdAsync(int boardId)
    {
        return await _dbContext.Lists.Where(l => l.BoardId == boardId).ToListAsync();
    }

    public async Task AddAsync(List list)
    {
        await _dbContext.Lists.AddAsync(list);
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}