using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SwaggerHubValidator.OpenApiModels
{
    public class ApiSchema
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
