using System.ComponentModel.DataAnnotations;

namespace Ombi.Store.Entities
{
    public abstract class Entity
    {
        [Key]
        [MaxLength(10)]
        [StringLength(20)]
        public int Id { get; set; }
    }
}