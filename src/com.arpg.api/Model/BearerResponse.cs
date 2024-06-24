/*
 * FastAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.arpg.api.Client.OpenAPIDateConverter;

namespace com.arpg.api.Model
{
    /// <summary>
    /// BearerResponse
    /// </summary>
    [DataContract(Name = "BearerResponse")]
    public partial class BearerResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BearerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BearerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BearerResponse" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken (required).</param>
        /// <param name="tokenType">tokenType (required).</param>
        public BearerResponse(string accessToken = default(string), string tokenType = default(string))
        {
            // to ensure "accessToken" is required (not null)
            if (accessToken == null)
            {
                throw new ArgumentNullException("accessToken is a required property for BearerResponse and cannot be null");
            }
            this.AccessToken = accessToken;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new ArgumentNullException("tokenType is a required property for BearerResponse and cannot be null");
            }
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "access_token", IsRequired = true, EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "token_type", IsRequired = true, EmitDefaultValue = true)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BearerResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
