using System.ComponentModel.DataAnnotations;

namespace _Pustok.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title1 { get; set; }
        [MaxLength(50)]
        public string Title2 { get; set; }
        [MaxLength(50)]
        public string Desc { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string BtnText { get; set; }
        public string RedirectUrl { get; set; }
        public int Order { get; set; }

    }
}
