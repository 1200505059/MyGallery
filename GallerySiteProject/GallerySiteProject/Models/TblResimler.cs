using System.ComponentModel.DataAnnotations;

namespace GallerySiteProject.Models
{
    public class TblResimler
    {
        [Key]
        public int ResimID { get; set; }
        public string ResimlerTitle { get; set; }
        public string ResimURL { get; set; }
    }
}
