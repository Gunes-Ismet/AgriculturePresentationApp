using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using AgriculturePresentationApp.Entities.DTO_s.AssistanceDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;

namespace AgriculturePresentationApp.Business.Services.Concretes
{
    public class AssistanceService : GenericService<Assistance,AssistanceDTO,CreateAssistanceDTO,UpdateAssistanceDTO,GetAssistanceVM>, IAssistanceService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IAssistanceRepository _assistanceRepository;

        public AssistanceService(IGenericRepository<Assistance> repository, IUnitofWork unitofWork, IMapper mapper, IWebHostEnvironment webHostEnvironment, IAssistanceRepository assistanceRepository) : base(repository, unitofWork, mapper)
        {
            _webHostEnvironment = webHostEnvironment;
            _assistanceRepository = assistanceRepository;
        }

        public async Task UpdateAsync(UpdateAssistanceDTO model)
        {
            string imageName = "noimage.png";
            if (model.UploadImage is not null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/assistance");

                if (!string.Equals(model.Image, "noimage.png"))
                {
                    string oldPath = Path.Combine(uploadDir, model.Image);
                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }
                imageName = $"{Guid.NewGuid()}_{model.UploadImage.FileName}";
                string filePath = Path.Combine(uploadDir, imageName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                await model.UploadImage.CopyToAsync(fileStream);
                fileStream.Close();
                model.Image = imageName;
            }
            var assistance = _mapper.Map<Assistance>(model);
            assistance.Image = model.Image;
            _assistanceRepository.Update(assistance);
            await _unitofWork.CommitAsync();
        }

        public async Task CreateAsync(CreateAssistanceDTO model)
        {
            string imageName = "noimage.png";
            if (model.UploadImage is not null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/assistance");
                imageName = $"{Guid.NewGuid()}_{model.UploadImage.FileName}";
                string filePath = Path.Combine(uploadDir, imageName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                await model.UploadImage.CopyToAsync(fileStream);
                fileStream.Close();
                model.Image = imageName;
            }
            var assistance = _mapper.Map<Assistance>(model);
            assistance.Image = model.Image;
            await _assistanceRepository.CreateAsync(assistance);
            await _unitofWork.CommitAsync();
        }


        public async Task RemoveAsync(int id)
        {
            var assistance = await _assistanceRepository.GetByIdAsync(id);
            string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/assistance");

            if (!string.Equals(assistance.Image, "noimage.png"))
            {
                string oldPath = Path.Combine(uploadDir, assistance.Image);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }
            }
            _assistanceRepository.Remove(assistance);
            await _unitofWork.CommitAsync();
        }

    }
}
