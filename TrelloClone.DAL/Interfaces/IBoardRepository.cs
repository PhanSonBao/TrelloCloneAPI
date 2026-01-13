using Microsoft.EntityFrameworkCore;
using TrelloClone.DAL.DBContext;
using TrelloClone.DAL.Entities;
using TrelloClone.DAL.Repositories;

namespace TrelloClone.DAL.Interfaces;

public interface IBoardRepository : IRepository<Board> 
{
    Task<Board?> GetBoardWithListAsync(int id);
}

public class BoardRepository(AppDbContext context) : Repository<Board>(context), IBoardRepository
{
    public async Task<Board?> GetBoardWithListAsync(int id)
    {
        return await _dbSet
            .Include(b => b.Lists.OrderBy(cl => cl.Position))
            .FirstOrDefaultAsync(b => b.Id == id);
    }
}