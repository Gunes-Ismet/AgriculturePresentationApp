using AgriculturePresentationApp.Entities.DTO_s.TeamDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;

namespace AgriculturePresentationApp.Business.Services.Interfaces
{
    public interface ITeamService : IGenericService<Team, TeamDTO, CreateTeamDTO, UpdateTeamDTO, GetTeamVM>
    {
        Task UpdateAsync(UpdateTeamDTO model);

        Task CreateAsync(CreateTeamDTO model);

        Task RemoveAsync(int id);
    }
}
