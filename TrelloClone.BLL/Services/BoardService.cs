using TrelloClone.DAL.Interfaces;
using TrelloClone.BLL.IServices;
using TrelloClone.BLL.DTOs.Boards;
using TrelloClone.BLL.DTOs.Lists;
using TrelloClone.DAL.Entities;

namespace TrelloClone.BLL.Services;

public class BoardService : IBoardService
{
    private readonly IBoardRepository _boardRepository;

    public BoardService(IBoardRepository boardRepository)
    {
        _boardRepository = boardRepository;
    }

    public async Task<BoardDto> GetBoardAsync(int id)
    {
        var board = await _boardRepository.GetBoardWithListAsync(id);
        if (board == null) throw new KeyNotFoundException("Board not found");
        
        // mapping enitty -> dto (Auto Mapper hoặc manual)
        return new BoardDto{Id = board.Id, Title = board.Title,
            Lists = board.Lists.Select(cl => new ListDto
            {
                Id = cl.Id,
                Title = cl.Title,
            }).ToList()
        };
    }

    public async Task<int> CreateBoardAsync(CreateBoardDto dto)
    {
        var board = new Board { Title = dto.Title, UserId = dto.UserId };
        await _boardRepository.AddAsync(board);
        await _boardRepository.SaveChangesAsync();
        return board.Id;
    }
}