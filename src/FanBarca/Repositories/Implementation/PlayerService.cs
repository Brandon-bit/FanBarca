using FanBarca.Models.Domain;
using FanBarca.Repositories.Abstract;
using FanBarca.Models.DTO;

namespace FanBarca.Repositories.Implementation;

public class PlayerService : IPlayerService
{
    private readonly DatabaseContext ctx;

    public PlayerService(DatabaseContext ctxParameter)
    {
        ctx = ctxParameter;
    }

    public Player GetById(int id)
    {
        return ctx.Players.Find(id)!;
    }

    public PlayerListVm List(string term="") 
    {
        var data = new PlayerListVm();
        var list = ctx.Players.ToList();

        if(!string.IsNullOrEmpty(term))
        {
            term = term.ToLower();
            list = list.Where(a => a.Name!.ToLower().Contains(term)).ToList();
            list = list.Take(5).ToList();
            data.PlayerList = list.AsQueryable();
            return data;
        }
        else
        {
            return null!;
        }
    }
}