using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using AgriculturePresentationApp.Entities.DTO_s.ImageDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;

namespace AgriculturePresentationApp.Business.Services.Concretes
{
    public class ImageService : GenericService<Image, ImageDTO, CreateImageDTO, UpdateImageDTO, GetImageVM>, IImageService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IImageRepository _ımageRepository;

        public ImageService(IGenericRepository<Image> repository, IUnitofWork unitofWork, IMapper mapper, IWebHostEnvironment webHostEnvironment, IImageRepository ımageRepository) : base(repository, unitofWork, mapper)
        {
            _webHostEnvironment = webHostEnvironment;
            _ımageRepository = ımageRepository;
        }

        public async Task UpdateAsync(UpdateImageDTO model)
        {
            string imageName = "noimage.png";
            if (model.UploadImage is not null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/image");

                if (!string.Equals(model.ImageUrl, "noimage.png"))
                {
                    string oldPath = Path.Combine(uploadDir, model.ImageUrl);
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
                model.ImageUrl = imageName;
            }
            var ımage = _mapper.Map<Image>(model);
            ımage.ImageUrl = model.ImageUrl;
            _ımageRepository.Update(ımage);
            await _unitofWork.CommitAsync();
        }

        public async Task CreateAsync(CreateImageDTO model)
        {
            string imageName = "noimage.png";
            if (model.UploadImage is not null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/image");
                imageName = $"{Guid.NewGuid()}_{model.UploadImage.FileName}";
                string filePath = Path.Combine(uploadDir, imageName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                await model.UploadImage.CopyToAsync(fileStream);
                fileStream.Close();
                model.ImageUrl = imageName;
            }
            var image = _mapper.Map<Image>(model);
            image.ImageUrl = model.ImageUrl;
            await _ımageRepository.CreateAsync(image);
            await _unitofWork.CommitAsync();
        }


        public async Task RemoveAsync(int id)
        {
            var team = await _ımageRepository.GetByIdAsync(id);
            string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/image");

            if (!string.Equals(team.ImageUrl, "noimage.png"))
            {
                string oldPath = Path.Combine(uploadDir, team.ImageUrl);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }
            }
            _ımageRepository.Remove(team);
            await _unitofWork.CommitAsync();
        }

    }
}
