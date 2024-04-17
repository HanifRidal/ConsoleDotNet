using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PointOfSales.Models.Domain
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

    }
}
