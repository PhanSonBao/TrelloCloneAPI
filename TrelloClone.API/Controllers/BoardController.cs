using Microsoft.AspNetCore.Mvc;
using TrelloClone.BLL.IServices;
using TrelloClone.BLL.DTOs;

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
    public async Task<IActionResult> Create(BoardDto dto)
    {
        await _boardService.BoardAsync(dto);
        return CreatedAtAction(nameof(Get), new {id = 111111}, null);
    }
}