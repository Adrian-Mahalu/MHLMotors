using AutoMapper;
using MHL_Motors.AutoMappers;
using MHL_Motors.Core.Constants;
using MHL_Motors.DataBuilders.DataBuildersConstants;
using MHL_Motors.Models.CarDataModels;
using System.Text.RegularExpressions;


namespace MHL_Motors.DataBuilders.DataBuilderHelpers
{
    public static class CarDataBuilderHelperMethods
    {
        public static string[] GetCarsFilePaths()
        {
            return Directory.GetFiles("C:\\MHL-Motors\\Data");
        }
        public static Car SetCarContentFileTabs(Dictionary<string, string> CarSpecValueDictionary, Car car)
        {
            car.HasGeneralInformationSpecs = CarSpecValueDictionary.Keys.Any(value => value.Contains(DataBuilderConstants.GeneralInformationSpecs));
            car.HasPerformanceSpecs = CarSpecValueDictionary.Keys.Any(value => value.Contains(DataBuilderConstants.PerformanceSpecs));
            car.HasEngineSpecs = CarSpecValueDictionary.Keys.Any(value => value.Contains(DataBuilderConstants.EngineSpecs));
            car.HasSpaceVolumeAndWeightsSpescs = CarSpecValueDictionary.Keys.Any(value => value.Contains(DataBuilderConstants.SpaceVolumeAndWeightsSpecs));
            car.HasDimensionsSpecs = CarSpecValueDictionary.Keys.Any(value => value.Contains(DataBuilderConstants.DimensionsSpecs));
            car.HasDrivetrainBrakesAndSuspensionSpecs = CarSpecValueDictionary.Keys.Any(value => value.Contains(DataBuilderConstants.DrivetrainBrakesAndSuspensionSpecs));

            return car;
        }
        public static bool AreValidCarContentTabs(Car car)
        {
            return car.HasGeneralInformationSpecs ||
                car.HasPerformanceSpecs ||
                car.HasEngineSpecs ||
                car.HasSpaceVolumeAndWeightsSpescs ||
                car.HasDimensionsSpecs ||
                car.HasDrivetrainBrakesAndSuspensionSpecs;
        }
        public static string GetFuelByFuelType(string fuelType)
        {
            if (!string.IsNullOrEmpty(fuelType))
            {
                if (fuelType.ToLower().Contains(DataBuilderConstants.Hybrid.ToLower()))
                {
                    return DataBuilderConstants.Hybrid;
                }
                else if (fuelType.ToLower().Contains(DataBuilderConstants.Petrol.ToLower()))
                {
                    return DataBuilderConstants.Petrol;
                }
                else if (fuelType.ToLower().Contains(DataBuilderConstants.Diesel.ToLower()))
                {
                    return DataBuilderConstants.Diesel;
                }
                else if (fuelType.ToLower().Contains(DataBuilderConstants.Electricity.ToLower()))
                {
                    return DataBuilderConstants.Electricity;
                }
                else if (fuelType.ToLower().Contains(DataBuilderConstants.Hydrogen.ToLower()))
                {
                    return DataBuilderConstants.Hydrogen;
                }
            }
            return string.Empty;
        }
        public static Dictionary<string, string> BuildRawDictionaryFromCarContentHtmlFile(string carHtmlFilePath)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(carHtmlFilePath))
            {
                string carContent = reader.ReadToEnd();

                while (!string.IsNullOrEmpty(carContent))
                {
                    int indexOfCompleteOpenTrTag = carContent.IndexOf("<tr>");
                    int indexOfPartiallyOpenTrTag = carContent.IndexOf("<tr ");
                    int indexOfClosedTrTag = carContent.IndexOf("</tr>");
                    string thKey = string.Empty;
                    string tdValue = string.Empty;
                    string currentTr = string.Empty;

                    if (indexOfCompleteOpenTrTag != -1 && indexOfClosedTrTag != -1)
                    {
                        if (indexOfCompleteOpenTrTag < indexOfPartiallyOpenTrTag || indexOfPartiallyOpenTrTag == -1)
                        {
                            try
                            {
                                indexOfCompleteOpenTrTag += "<tr>".Length;
                                currentTr = carContent.Substring(indexOfCompleteOpenTrTag, indexOfClosedTrTag - indexOfCompleteOpenTrTag).Trim();

                                int indexOfOpenThTag = currentTr.IndexOf("<th>");
                                int indexOfClosedThTag = currentTr.IndexOf("</th>");
                                indexOfOpenThTag += indexOfOpenThTag + "<th>".Length;

                                thKey = currentTr.Substring(indexOfOpenThTag, indexOfClosedThTag - indexOfOpenThTag).Trim();

                                int indexOfCompleteOpenTdTag = currentTr.IndexOf("<td>");
                                int indexOfPartiallyOpenTdTag = currentTr.IndexOf("<td ");
                                int indexOfClosedTdTag = currentTr.IndexOf("</td>");

                                if (indexOfCompleteOpenTdTag < indexOfPartiallyOpenTdTag &&
                                    indexOfClosedTdTag >= 0 && indexOfPartiallyOpenTdTag >= 0)
                                {
                                    indexOfCompleteOpenTdTag += "<td>".Length;
                                    tdValue = currentTr.Substring(indexOfCompleteOpenTdTag, indexOfClosedTdTag - indexOfCompleteOpenTdTag).Trim();
                                }
                                else if (indexOfCompleteOpenTdTag > indexOfPartiallyOpenTdTag &&
                                    indexOfClosedTdTag >= 0 && indexOfPartiallyOpenTdTag >= 0)
                                {
                                    indexOfPartiallyOpenTdTag += "<td ".Length;
                                    tdValue = currentTr.Substring(indexOfPartiallyOpenTdTag, indexOfClosedTdTag - indexOfPartiallyOpenTdTag).Trim();
                                }
                                else if (indexOfCompleteOpenTdTag >= 0 && indexOfPartiallyOpenTdTag == -1)
                                {
                                    indexOfCompleteOpenTdTag += "<td>".Length;
                                    tdValue = currentTr.Substring(indexOfCompleteOpenTdTag, indexOfClosedTdTag - indexOfCompleteOpenTdTag).Trim();
                                }
                                else if (indexOfCompleteOpenTdTag == -1 && indexOfClosedTdTag >= 0)
                                {
                                    indexOfPartiallyOpenTdTag += "<td ".Length;
                                    tdValue = currentTr.Substring(indexOfPartiallyOpenTdTag, indexOfClosedTdTag - indexOfPartiallyOpenTdTag).Trim();
                                }

                                if (!keyValuePairs.ContainsKey(thKey))
                                {
                                    keyValuePairs.Add(thKey, tdValue);
                                }
                                carContent = carContent.Substring(indexOfClosedTrTag + "</tr>".Length);
                            }
                            catch (Exception e)
                            {
                            }
                        }
                        else if (indexOfPartiallyOpenTrTag < indexOfCompleteOpenTrTag || indexOfCompleteOpenTrTag == -1)
                        {
                            try
                            {
                                indexOfPartiallyOpenTrTag += "<tr ".Length;
                                currentTr = carContent.Substring(indexOfPartiallyOpenTrTag, indexOfClosedTrTag - indexOfPartiallyOpenTrTag).Trim();

                                int indexOfOpenThTag = currentTr.IndexOf("<th>");
                                int indexOfClosedThTag = currentTr.IndexOf("</th>");
                                indexOfOpenThTag += indexOfOpenThTag + "<th>".Length;

                                thKey = currentTr.Substring(indexOfOpenThTag, indexOfClosedThTag - indexOfOpenThTag).Trim();

                                int indexOfCompleteOpenTdTag = currentTr.IndexOf("<td>");
                                int indexOfPartiallyOpenTdTag = currentTr.IndexOf("<td ");
                                int indexOfClosedTdTag = currentTr.IndexOf("</td>");

                                if (indexOfCompleteOpenTdTag < indexOfPartiallyOpenTdTag &&
                                    indexOfClosedTdTag >= 0 && indexOfPartiallyOpenTdTag >= 0)
                                {
                                    indexOfCompleteOpenTdTag += "<td>".Length;
                                    tdValue = currentTr.Substring(indexOfCompleteOpenTdTag, indexOfClosedTdTag - indexOfCompleteOpenTdTag).Trim();
                                }
                                else if (indexOfCompleteOpenTdTag > indexOfPartiallyOpenTdTag &&
                                    indexOfClosedTdTag >= 0 && indexOfPartiallyOpenTdTag >= 0)
                                {
                                    indexOfPartiallyOpenTdTag += "<td ".Length;
                                    tdValue = currentTr.Substring(indexOfPartiallyOpenTdTag, indexOfClosedTdTag - indexOfPartiallyOpenTdTag).Trim();
                                }
                                else if (indexOfCompleteOpenTdTag >= 0 && indexOfPartiallyOpenTdTag == -1)
                                {
                                    indexOfCompleteOpenTdTag += "<td>".Length;
                                    tdValue = currentTr.Substring(indexOfCompleteOpenTdTag, indexOfClosedTdTag - indexOfCompleteOpenTdTag).Trim();
                                }
                                else if (indexOfCompleteOpenTdTag == -1 && indexOfClosedTdTag >= 0)
                                {
                                    indexOfPartiallyOpenTdTag += "<td ".Length;
                                    tdValue = currentTr.Substring(indexOfPartiallyOpenTdTag, indexOfClosedTdTag - indexOfPartiallyOpenTdTag).Trim();
                                }
                                if (!keyValuePairs.ContainsKey(thKey))
                                {
                                    keyValuePairs.Add(thKey, tdValue);
                                }
                                carContent = carContent.Substring(indexOfClosedTrTag + "</tr>".Length);
                            }
                            catch (Exception e)
                            {
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        carContent = string.Empty;
                    }
                }

            }
            return keyValuePairs;
        }
        public static Dictionary<string, string> FormatCarPropertiesFromSpecValueDictionary(Dictionary<string, string> carSpecValueRawDictionary)
        {
            var carSpecValueFormattedDictionary = new Dictionary<string, string>();

            foreach (var pair in carSpecValueRawDictionary)
            {
                if (!string.IsNullOrEmpty(pair.Value))
                {
                    string value = pair.Value.Trim();
                    value = RemoveHtmlTagsAndText(value);

                    if (!char.IsDigit(value[0]))
                    {
                        carSpecValueFormattedDictionary.Add(pair.Key, value);
                    }
                    else
                    {
                        value = GetFirstNumberFromString(value);
                        carSpecValueFormattedDictionary.Add(pair.Key, value);
                    }
                }
            }
            carSpecValueFormattedDictionary = FormatCarProperiesExceptionsFromSpecValueDictionary(carSpecValueRawDictionary, carSpecValueFormattedDictionary);

            return carSpecValueFormattedDictionary;
        }
        public static Car SetCarPropertiesFromSpecValueDictionary(Dictionary<string, string> carSpecValueFormattedDictionary, Car car)
        {
            car = MapCarPropertiesFromSpecValueDictionary(carSpecValueFormattedDictionary, car);
            car = SetAdditionalCalculatedCarProperties(car);

            return car;
        }
        private static Car MapCarPropertiesFromSpecValueDictionary(Dictionary<string, string> carSpecValueFormattedDictionary, Car car)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            var mapper = config.CreateMapper();

            car = mapper.Map<Car>(carSpecValueFormattedDictionary);

            return car;
        }
        private static Car SetAdditionalCalculatedCarProperties(Car car)
        {
            string brandLogoPath = $"C:\\MHL-Motors\\UI\\MHL-Motors.UI\\src\\assets\\cars\\logos\\{car.BrandName}\\{car.BrandName}HomePageLogo.svg";
            string brandLogoPathFrontEnd = $"../../assets/cars/logos/{car.BrandName}/{car.BrandName}HomePageLogo.svg";
            car.BrandLogoPath = File.Exists(brandLogoPath) ? brandLogoPathFrontEnd : DataBuilderConstants.DefaultBrandMissingLogoPath;

            string generationLogoPath = $"C:\\MHL-Motors\\UI\\MHL-Motors.UI\\src\\assets\\cars\\logos\\{car.BrandName}\\{car.BrandName}GenerationLogo.svg";
            string generationLogoPathFrontEnd = "../../assets/cars/logos/{car.BrandName}/{car.BrandName}{car.ModelName}{car.GenerationName}GenerationLogo.svg";
            car.GenerationLogoPath = File.Exists(generationLogoPath) ? generationLogoPathFrontEnd : DataBuilderConstants.DefaultGenerationMissingLogoPath;

            string modelLogoPath = $"C:\\MHL-Motors\\UI\\MHL-Motors.UI\\src\\assets\\cars\\logos\\{car.ModelName}\\{car.ModelName}ModelLogo.svg";
            string modelLogoPathFront = "../../assets/cars/logos/{car.BrandName}/{car.BrandName}{car.ModelName}ModelLogo.svg";
            car.ModelLogoPath = File.Exists(modelLogoPath) ? modelLogoPathFront : DataBuilderConstants.DefaultModelMissingLogoPath;

            if (!string.IsNullOrEmpty(car.FuelType))
            {
                if (car.FuelType.ToLower().Contains(FuelTypeConstants.Petrol) &&
                                car.FuelType.ToLower().Contains(FuelTypeConstants.Electricity))
                {
                    car.Fuel = FuelTypeConstants.Hybrid;
                }
                else if (car.FuelType.ToLower().Contains(FuelTypeConstants.Petrol) &&
                    !car.FuelType.ToLower().Contains(FuelTypeConstants.Electricity))
                {
                    car.Fuel = FuelTypeConstants.Petrol;
                }
                else if (car.FuelType.ToLower().Contains(FuelTypeConstants.Diesel))
                {
                    car.Fuel = FuelTypeConstants.Diesel;
                }
                else if (car.FuelType.ToLower().Contains(FuelTypeConstants.Hydrogen))
                {
                    car.Fuel = FuelTypeConstants.Hydrogen;
                }
                else if (car.FuelType.ToLower().Contains(FuelTypeConstants.Electricity))
                {
                    car.Fuel = FuelTypeConstants.Electricity;
                }
            }

            if (!string.IsNullOrEmpty(car.Power))
            {
                car.HorsePower = Convert.ToInt32(GetFirstNumberFromString(car.Power));
            }

            return car;
        }
        private static Dictionary<string, string> FormatCarProperiesExceptionsFromSpecValueDictionary(
            Dictionary<string, string> carSpecValueRawDictionary, Dictionary<string, string> carSpecValueFormattedDictionary)
        {
            foreach (var pair in carSpecValueRawDictionary)
            {
                if (!string.IsNullOrEmpty(pair.Value))
                {
                    if (pair.Key.Contains(CarDataBuilderConstants.StartOfProduction))
                    {
                        carSpecValueFormattedDictionary[pair.Key] = GetFirstNumberFromString(pair.Value);
                    }
                    else if (pair.Key.Contains(CarDataBuilderConstants.EndOfProduction))
                    {
                        carSpecValueFormattedDictionary[pair.Key] = GetFirstNumberFromString(pair.Value);
                    }
                    else if (pair.Key.Contains(CarDataBuilderConstants.EngineName))
                    {
                        carSpecValueFormattedDictionary[pair.Key] = pair.Value;
                    }
                }
            }

            return carSpecValueFormattedDictionary;
        }
        private static string RemoveHtmlTagsAndText(string htmlString)
        {
            // Regular expression to match HTML tags and the text between them
            string htmlTagAndTextPattern = @"<.*?>";

            // Remove HTML tags and the text between them from the input string
            string plainText = Regex.Replace(htmlString, htmlTagAndTextPattern, string.Empty);

            return plainText;
        }
        private static string GetFirstNumberFromString(string htmlString)
        {
            if (string.IsNullOrEmpty(htmlString))
                return null;

            // Regular expression to match the first number (integer or decimal) in the string
            string pattern = @"[-+]?\d+(\.\d+)?";

            Match match = Regex.Match(htmlString, pattern);

            return match.Success ? match.Value : null;
        }
    }
}
