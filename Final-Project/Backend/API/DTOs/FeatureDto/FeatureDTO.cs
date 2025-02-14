namespace API.DTOs.FeatureDto
{
    using Data_Layer.Entities.Flights;

    namespace API.DTOs
    {
        public class FeatureDTO
        {
            public int Id { get; set; }
            public bool Meal { get; set; }
            public bool Wifi { get; set; }
            public bool Video { get; set; }
            public bool Usb { get; set; }
            public int AirplaneId { get; set; }

            // تحويل كيان Feature إلى FeatureDTO
            public static FeatureDTO MapToFeatureDTO(Feature feature)
            {
                return new FeatureDTO
                {
                    Id = feature.Id,
                    Meal = feature.Meal,
                    Wifi = feature.Wifi,
                    Video = feature.Video,
                    Usb = feature.Usb,
                    AirplaneId = feature.AirplaneId
                };
            }

            // تحويل FeatureDTO إلى كيان Feature
            public static Feature MapToFeature(FeatureDTO featureDTO)
            {
                return new Feature
                {
                    Id = featureDTO.Id,
                    Meal = featureDTO.Meal,
                    Wifi = featureDTO.Wifi,
                    Video = featureDTO.Video,
                    Usb = featureDTO.Usb,
                    AirplaneId = featureDTO.AirplaneId
                };
            }
        }
    }

}
