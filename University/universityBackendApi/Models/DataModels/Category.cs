using System.ComponentModel.DataAnnotations;

namespace universityBackendApi.Models.DataModels
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name = string.Empty;
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
