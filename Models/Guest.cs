using System.ComponentModel.DataAnnotations;

namespace fproject.Models
{
    public class Guest
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email  { get; set; }
        public string? Phone { get; set; }
        public bool WellAttend { get; set; }
    }
}
