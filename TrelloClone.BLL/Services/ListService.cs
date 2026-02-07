using TrelloClone.BLL.DTOs.Lists;
using TrelloClone.BLL.IServices;
using TrelloClone.DAL.Entities;
using TrelloClone.DAL.Interfaces;

namespace TrelloClone.BLL.Services;

public class ListService : IListService
{
    private readonly IListRepository _listRepository;

    public ListService(IListRepository listRepository)
    {
        _listRepository = listRepository;
    }

    public async Task<List<ListDto>> GetByBoardAsync(Guid boardId)
    {
        var lists = await _listRepository.GetByBoardIdAsync(boardId);
        return lists.Select(item => new ListDto()
        {
            Id = item.UID,
            Title = item.Title,
        }).ToList();
    }

    public async Task<int> CreateListAsync(Guid boardId, CreateListDto dto)
    {
        var list = new List { Title = dto.Title, BoardId =  boardId };
        await _listRepository.AddAsync(list);
        await _listRepository.SaveChangesAsync();
        return list.UID;
    }
}