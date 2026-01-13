using Microsoft.AspNetCore.Mvc;
using TrelloClone.BLL.IServices;
using TrelloClone.BLL.DTOs.Boards;

namespace TrelloClone.API.Controllers;
[ApiController]
[Route("api/boards")]
public class BoardController : ControllerBase
{
    private readonly IBoardService _boardService;
    public BoardController(IBoardService boardService) => _boardService = boardService;

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var board = await _boardService.GetBoardAsync(id);
        return Ok(board);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBoardDto dto)
    {
        await _boardService.CreateBoardAsync(dto);
        // Id tạm thời, sửa sau
        return CreatedAtAction(nameof(Get), new {id = 0}, null);
    }
}