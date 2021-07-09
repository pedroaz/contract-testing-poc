using SwaggerHubContractValidator.Validator;
using SwaggerHubValidator.OpenApiModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SwaggerHubValidator.Validator
{
    public class Validator
    {
        public OpenApiSchema Schema { get; private set; }
        public ValidatorQuery Query { get; set; } = new ValidatorQuery();

        public Validator(string openApiJson)
        {
            Schema = JsonSerializer.Deserialize<OpenApiSchema>(openApiJson);
        }

        public Validator Path(string path)
        {
            Query.Path = path;
            return this;
        }

        public ValidatorResponse Validate()
        {
            return new ValidatorResponse() {
                IsValid = HasQuery()
            };
        }

        private bool HasQuery()
        {
            if (Schema.Paths.ContainsKey(Query.Path)) return true;

            return false;
        }
    }
}
