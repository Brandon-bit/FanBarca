using FanBarca.Models.Domain;

namespace FanBarca.Models.DTO;

public class PlayerListVm
{
    public IQueryable<Player>? PlayerList {get; set;}
    public int PageSize {get; set;}
    public string? Term {get; set;}

}