using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SwaggerHubValidator.OpenApiModels
{
    public class OpenApiSchema
    {
        [JsonPropertyName("openapi")]
        public string OpenApiVersion { get; set; }

        [JsonPropertyName("info")]
        public OpenApiInfo Information { get; set; }

        [JsonPropertyName("paths")]
        public Dictionary<string, OpenApiPath> Paths { get; set; }
    }
}
