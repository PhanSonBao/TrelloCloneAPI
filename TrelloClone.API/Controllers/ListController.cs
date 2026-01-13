using Microsoft.AspNetCore.Mvc;
using TrelloClone.BLL.IServices;
using TrelloClone.BLL.DTOs.Lists;

namespace TrelloClone.API.Controllers;

[ApiController]
[Route("api/boards/{boardId}/lists")]
public class ListController : ControllerBase
{
    private readonly IListService _listService;
    public ListController(IListService listService)
    {
        _listService = listService;
    }

    [HttpGet]
    public async Task<IActionResult> Get(int boardId)
    {
        var list = await _listService.GetByBoardAsync(boardId);
        return Ok(list);
    }

    [HttpPost]
    public async Task<IActionResult> Create(int boardId, CreateListDto dto)
    {
        var id = await _listService.CreateListAsync(boardId, dto);
        return CreatedAtAction(nameof(Get), new {boardId = id}, null);
    }
}