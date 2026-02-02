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
        return new BoardDto{UID = board.UID, Title = board.Title,
            Lists = board.Lists.Select(l => new ListDto
            {
                Id = l.UID,
                Title = l.Title,
            }).ToList()
        };
    }

    public async Task<int> CreateBoardAsync(CreateBoardDto dto)
    {
        var board = new Board { Title = dto.Title, UserId = dto.UserId, CreatedAt = dto.CreteAt};
        await _boardRepository.AddAsync(board);
        await _boardRepository.SaveChangesAsync();
        return board.UID;
    }
}