using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SwaggerHubValidator.OpenApiModels
{
    public class ApiRequest
    {
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        //[JsonPropertyName("parameters")]
        //public List<ApiParameter> Parameters { get; set; }

        //[JsonPropertyName("requestBody")]
        //public dynamic RequestBody { get; set; }

        //[JsonPropertyName("responses")]
        //public dynamic Responses { get; set; }
    }
}
