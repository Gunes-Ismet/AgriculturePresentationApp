using AgriculturePresentationApp.Entities.DTO_s.AboutDTO_s;
using AgriculturePresentationApp.Entities.DTO_s.AdressDTO_s;
using AgriculturePresentationApp.Entities.DTO_s.AnnouncementDTO_s;
using AgriculturePresentationApp.Entities.DTO_s.AssistanceDTO_s;
using AgriculturePresentationApp.Entities.DTO_s.ContactDTO_s;
using AgriculturePresentationApp.Entities.DTO_s.ImageDTO_s;
using AgriculturePresentationApp.Entities.DTO_s.SocialMediaDTO_s;
using AgriculturePresentationApp.Entities.DTO_s.TeamDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using AutoMapper;

namespace AgriculturePresentationApp.Business.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {

            #region Adress
            CreateMap<Adress, AdressDTO>().ReverseMap();
            CreateMap<Adress, CreateAdressDTO>().ReverseMap();
            CreateMap<Adress, UpdateAdressDTO>().ReverseMap();
            CreateMap<Adress, GetAdressVM>().ReverseMap();
            #endregion


            #region Announcement
            CreateMap<Announcement, AnnouncementDTO>().ReverseMap();
            CreateMap<Announcement, CreateAnnouncementDTO>().ReverseMap();
            CreateMap<Announcement, UpdateAnnouncementDTO>().ReverseMap();
            CreateMap<Announcement, GetAnnouncementVM>().ReverseMap();
            #endregion

            #region Assistance
            CreateMap<Assistance, AssistanceDTO>().ReverseMap();
            CreateMap<Assistance, CreateAssistanceDTO>().ReverseMap();
            CreateMap<Assistance, UpdateAssistanceDTO>().ReverseMap();
            CreateMap<Assistance, GetAssistanceVM>().ReverseMap();
			#endregion



			#region Contact
			CreateMap<Contact, ContactDTO>().ReverseMap();
            CreateMap<Contact, CreateContactDTO>().ReverseMap();
            CreateMap<Contact, UpdateContactDTO>().ReverseMap();
            CreateMap<Contact, GetContactVM>().ReverseMap();
            #endregion


            #region Image
            CreateMap<Image, ImageDTO>().ReverseMap();
            CreateMap<Image, GetImageVM>().ReverseMap();
            CreateMap<Image, CreateImageDTO>().ReverseMap();
            CreateMap<Image, UpdateImageDTO>().ReverseMap();
            #endregion

            #region Team
            CreateMap<Team, TeamDTO>().ReverseMap();
            CreateMap<Team, CreateTeamDTO>().ReverseMap();
            CreateMap<Team, UpdateTeamDTO>().ReverseMap();
            CreateMap<Team, GetTeamVM>().ReverseMap();
			#endregion

			#region Social Media
			CreateMap<SocialMedia, SocialMediaDTO>().ReverseMap();
			CreateMap<SocialMedia, CreateSocialMediaDTO>().ReverseMap();
			CreateMap<SocialMedia, UpdateSocialMediaDTO>().ReverseMap();
			CreateMap<SocialMedia, GetSocialMediaVM>().ReverseMap();
			#endregion

			#region About
			CreateMap<About, AboutDTO>().ReverseMap();
			CreateMap<About, CreateAboutDTO>().ReverseMap();
			CreateMap<About, UpdateAboutDTO>().ReverseMap();
			CreateMap<About, GetAboutVM>().ReverseMap();
            #endregion

        }
    }
}
