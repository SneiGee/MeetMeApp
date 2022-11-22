using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class MemberUpdateDto
    {
        // public DateTime DateOfBirth { get; set; }
        [Required]
        public string Introduction { get; set; } = string.Empty;
        [Required]
        public string LookingFor { get; set; } = string.Empty;
        [Required]
        public string Interests { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string Country { get; set; } = string.Empty;
    }
}