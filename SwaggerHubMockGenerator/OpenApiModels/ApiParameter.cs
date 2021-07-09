using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SwaggerHubValidator.OpenApiModels
{
    public class ApiParameter
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("in")]
        public string In { get; set; }
        [JsonPropertyName("required")]
        public string Required { get; set; }
        [JsonPropertyName("style")]
        public string Style { get; set; }
        [JsonPropertyName("explode")]
        public string Explode { get; set; }
        [JsonPropertyName("schema")]
        public string Schema { get; set; }
    }
}
