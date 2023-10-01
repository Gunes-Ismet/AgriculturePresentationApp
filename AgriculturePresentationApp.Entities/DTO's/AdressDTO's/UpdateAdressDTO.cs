using System.ComponentModel;

namespace AgriculturePresentationApp.Entities.DTO_s.AdressDTO_s
{
    public class UpdateAdressDTO
    {
        public int Id { get; set; }
        [DisplayName("Adres Satırı 1")]
        public string Description1 { get; set; }
        [DisplayName("E-Mail")]
        public string Description2 { get; set; }
        [DisplayName("Adres Satırı 3")]
        public string Description3 { get; set; }
        [DisplayName("Telefon Numarası")]
        public string Description4 { get; set; }
        public string MapInfo { get; set; }
    }
}
