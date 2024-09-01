namespace MHL_Motors.Models.CarDataModels
{
    public class Brand
    {
        private string _brandName;
        public Guid Id { get; set; }
        public string? BrandName
        {
            get { return _brandName; }
            set
            {
                _brandName = value;
                FirstLetter = !string.IsNullOrEmpty(_brandName) ? _brandName.Substring(0, 1) : string.Empty;
            }
        }
        public bool IsCommonBrand { get; set; } = false;
        public string? FirstLetter { get; set; }
        public string? LogoPath { get; set; }
    }
}
