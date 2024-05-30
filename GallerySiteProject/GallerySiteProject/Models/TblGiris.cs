using System.ComponentModel.DataAnnotations;

namespace GallerySiteProject.Models
{
    public class TblGiris
    {
        [Key]
        public int GirisID { get; set; }
        public string GirisAdSoyad { get; set; }
        public string GirisAciklama { get; set; }
        public string GirisFacebookURL { get; set; }    
        public string GirisLinkedinURL { get; set; }
        public string GirisMailURL { get; set; }
        public string GirisInstagramURL { get; set; }
    }
}
