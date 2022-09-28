using System.ComponentModel.DataAnnotations;
//para hacer validaciones en los campos

namespace universityBackendApi.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = String.Empty;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; } = String.Empty;
        public bool IsDeleted { get; set; } = false;

    }
}
