using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SwaggerHubValidator.OpenApiModels
{
    public class OpenApiInfo
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
