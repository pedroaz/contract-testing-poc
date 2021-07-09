using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SwaggerHubValidator.OpenApiModels
{
    public class OpenApiPath
    {
        [JsonPropertyName("get")]
        public ApiRequest GetRequest { get; set; }

        [JsonPropertyName("post")]
        public ApiRequest PostRequest { get; set; }
    }
}
