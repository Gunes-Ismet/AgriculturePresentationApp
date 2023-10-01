using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using AgriculturePresentationApp.Entities.DTO_s.TeamDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;

namespace AgriculturePresentationApp.Business.Services.Concretes
{
    public class TeamService : GenericService<Team, TeamDTO, CreateTeamDTO, UpdateTeamDTO, GetTeamVM>, ITeamService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ITeamRepository _teamRepository;

        public TeamService(IGenericRepository<Team> repository, IUnitofWork unitofWork, IMapper mapper, IWebHostEnvironment webHostEnvironment, ITeamRepository teamRepository) : base(repository, unitofWork, mapper)
        {
            _webHostEnvironment = webHostEnvironment;
            _teamRepository = teamRepository;
        }

        public async Task UpdateAsync(UpdateTeamDTO model)
        {
            string imageName = "noimage.png";
            if (model.UploadImage is not null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/team");

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
            var team = _mapper.Map<Team>(model);
            team.ImageUrl = model.ImageUrl;
            _teamRepository.Update(team);
            await _unitofWork.CommitAsync();
        }

        public async Task CreateAsync(CreateTeamDTO model)
        {
            string imageName = "noimage.png";
            if (model.UploadImage is not null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/team");
                imageName = $"{Guid.NewGuid()}_{model.UploadImage.FileName}";
                string filePath = Path.Combine(uploadDir, imageName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                await model.UploadImage.CopyToAsync(fileStream);
                fileStream.Close();
                model.ImageUrl = imageName;
            }
            var team = _mapper.Map<Team>(model);
            team.ImageUrl = model.ImageUrl;
            await _teamRepository.CreateAsync(team);
            await _unitofWork.CommitAsync();
        }


        public async Task RemoveAsync(int id)
        {
            var team = await _teamRepository.GetByIdAsync(id);
            string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/team");

            if (!string.Equals(team.ImageUrl, "noimage.png"))
            {
                string oldPath = Path.Combine(uploadDir, team.ImageUrl);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }
            }
            _teamRepository.Remove(team);
            await _unitofWork.CommitAsync();
        }
    }
}
