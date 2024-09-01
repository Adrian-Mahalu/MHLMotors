using MHL_Motors.DataBuilders.DataBuilderHelpers;
using MHL_Motors.Models.CarDataModels;

namespace MHL_Motors.DataBuilders.DataBuilders
{
    public static class CarDataBuilder
    {
        public static Car BuildCarFromCarContentHtmlFile(string carContentHtmlFilePath)
        {
            Car car = new Car();

            var carSpecValueRawDictionary = CarDataBuilderHelperMethods.BuildRawDictionaryFromCarContentHtmlFile(carContentHtmlFilePath);
            car = CarDataBuilderHelperMethods.SetCarContentFileTabs(carSpecValueRawDictionary, car);

            if (CarDataBuilderHelperMethods.AreValidCarContentTabs(car))
            {
                var carSpecValueFormattedDictionary = CarDataBuilderHelperMethods.FormatCarPropertiesFromSpecValueDictionary(carSpecValueRawDictionary);
                car = CarDataBuilderHelperMethods.SetCarPropertiesFromSpecValueDictionary(carSpecValueFormattedDictionary, car);
            }

            return car;
        }
    }
}
