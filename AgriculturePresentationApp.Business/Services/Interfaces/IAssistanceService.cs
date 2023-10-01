using AgriculturePresentationApp.Entities.DTO_s.AssistanceDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;

namespace AgriculturePresentationApp.Business.Services.Interfaces
{
    public interface IAssistanceService : IGenericService<Assistance, AssistanceDTO, CreateAssistanceDTO, UpdateAssistanceDTO, GetAssistanceVM>
    {
        Task UpdateAsync(UpdateAssistanceDTO model);

        Task CreateAsync(CreateAssistanceDTO model);

        Task RemoveAsync(int id);
    }
}
