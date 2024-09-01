namespace MHL_Motors.Models.CarDataModels
{
    public class Model
    {
        private string _modelName;
        public Guid Id { get; set; }
        public string ModelName
        {
            get { return _modelName; }
            set
            {
                _modelName = value;
                FirstCharacter = !string.IsNullOrEmpty(_modelName) ? _modelName.Substring(0, 1) : string.Empty;
            }
        }
        public string BrandName { get; set; }
        public string FirstCharacter { get; private set; }
        public string LogoPath { get; set; }
    }
}
