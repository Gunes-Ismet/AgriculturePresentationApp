using AgriculturePresentationApp.Entities.Entities.Concrete;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentationApp.Entities.DTO_s.AdminDTO_s
{
    public class UpdateAdminDTO
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur!!")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur!!")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public UpdateAdminDTO()
        {

        }

        public UpdateAdminDTO(ApplicationAdmin user)
        {
            UserName = user.UserName;
            Password = user.PasswordHash;
        }
    }
}
