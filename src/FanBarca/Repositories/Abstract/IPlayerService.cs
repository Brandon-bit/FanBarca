using FanBarca.Models.Domain;
using FanBarca.Models.DTO;

namespace FanBarca.Repositories.Abstract;

public interface IPlayerService
{
    Player GetById(int id); 
    PlayerListVm List(string term="");
}