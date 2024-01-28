using System.ComponentModel.DataAnnotations;

namespace VacationManagement.Models
{
    public class VacationType : EntityBase
    {
        [Display(Name = "Vacation Name")]
        [StringLength(200)]
        public string VacationName { get; set; }
        [Display(Name = "Vacation Color")]
        [StringLength(7)]
        public string backgroundColor { get; set; }
        [Display(Name = "Number Days")]
        public int NumberDays { get; set; }
    }
}