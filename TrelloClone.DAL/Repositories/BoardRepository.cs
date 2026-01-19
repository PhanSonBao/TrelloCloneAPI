using System.Linq.Expressions;
using TrelloClone.DAL.DBContext;
using TrelloClone.DAL.Entities;
using TrelloClone.DAL.Interfaces;

namespace TrelloClone.DAL.Repositories;

public class BoardRepository : IBoardRepository
{
    private readonly AppDbContext _dbContext;

    public BoardRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<IEnumerable<Board>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Board> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Board entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Board entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Board entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Board>> FindAsync(Expression<Func<Board, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Board?> GetBoardWithListAsync(int id)
    {
        throw new NotImplementedException();
    }
}