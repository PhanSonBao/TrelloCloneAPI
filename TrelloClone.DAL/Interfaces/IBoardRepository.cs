using Microsoft.EntityFrameworkCore;
using TrelloClone.DAL.DBContext;
using TrelloClone.DAL.Entities;
using TrelloClone.DAL.Repositories;

namespace TrelloClone.DAL.Interfaces;

public interface IBoardRepository : IRepository<Board> 
{
    Task<Board?> GetBoardWithListAsync(Guid uid);
}

public class BoardRepository(AppDbContext context) : Repository<Board>(context), IBoardRepository
{
    public async Task<Board?> GetBoardWithListAsync(Guid uid)
    {
        return await _dbSet
            .Include(b => b.Lists.OrderBy(l => l.Position))
            .FirstOrDefaultAsync(b => b.UID == uid);
    }

    // public async Task<Board> CreateBoardWithAsync()
    // {
    //     return await _dbSet
    //         .Include(b => b.Lists.OrderBy(cl => cl.Position))
    //         .FirstOrDefault();
    // }
}