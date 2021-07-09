using SwaggerHubValidator.Validator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerHubValidator.Factory
{
    public class ValidatorFactory
    {
        private string _openApiJson { get; set; }

        public ValidatorFactory(string json)
        {
            _openApiJson = json;
        }

        public Validator.Validator CreateNewValidator()
        {
            return new Validator.Validator(_openApiJson);
        }
    }
}
