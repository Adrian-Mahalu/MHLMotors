using System.ComponentModel.DataAnnotations.Schema;

namespace MHL_Motors.Models.CarDataModels
{
    [NotMapped]
    public  class CarAd
    {
        public Guid Id { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string GenerationName { get; set; }
        public bool IsCommonBrand { get; set; }
        public string EngineName { get; set; }
        public string Power { get; set; }
    }
}
