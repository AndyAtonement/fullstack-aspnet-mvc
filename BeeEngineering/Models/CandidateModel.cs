using System.ComponentModel.DataAnnotations;

namespace BeeEngineering.Models
{
    public class CandidateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The field Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The field Surname is required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "The field Country is required")]
        public string Country { get; set; }
    }
}
