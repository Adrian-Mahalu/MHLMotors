using System.ComponentModel.DataAnnotations.Schema;

namespace MHL_Motors.Models.CarDTOs
{
    [NotMapped]
    public class CarDTO
    {
        public Guid Id { get; set; }
    }
}
