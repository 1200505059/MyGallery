using System.ComponentModel.DataAnnotations;

namespace GallerySiteProject.Models
{
    public class TblHakkimda
    {
        [Key]
        public int HakkimdaID { get; set; }
        public string HakkimdaBaslik { get; set; }
        public string HakkimdaGiris { get; set; }
        public string HakkimdaText { get; set; }
        public string HakkimdaImageURL { get; set; }
    }
}
