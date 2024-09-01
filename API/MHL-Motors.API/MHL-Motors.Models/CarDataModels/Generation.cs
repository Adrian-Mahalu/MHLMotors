namespace MHL_Motors.Models.CarDataModels
{
    public class Generation
    {
        public Guid Id { get; set; }
        public string? GenerationName { get; set; }
        public int StartOfProduction { get; set; }
        public int EndOfProduction { get; set; }
        public string? BodyType { get; set; } = string.Empty;
        public string? LogoPath { get; set; } = string.Empty;
        public string? BrandName { get; set; } = string.Empty;
        public string? ModelName { get; set; } = string.Empty;
        public string? EmissionStandard { get; set; } = string.Empty;
        public string? FuelType { get; set; } = string.Empty;
        public int MinHorsePower { get; set; }
        public int MaxHorsePower { get; set; }
    }
}
