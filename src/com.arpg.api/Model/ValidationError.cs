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
    /// ValidationError
    /// </summary>
    [DataContract(Name = "ValidationError")]
    public partial class ValidationError : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidationError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        /// <param name="loc">loc (required).</param>
        /// <param name="msg">msg (required).</param>
        /// <param name="type">type (required).</param>
        public ValidationError(List<ValidationErrorLocInner> loc = default(List<ValidationErrorLocInner>), string msg = default(string), string type = default(string))
        {
            // to ensure "loc" is required (not null)
            if (loc == null)
            {
                throw new ArgumentNullException("loc is a required property for ValidationError and cannot be null");
            }
            this.Loc = loc;
            // to ensure "msg" is required (not null)
            if (msg == null)
            {
                throw new ArgumentNullException("msg is a required property for ValidationError and cannot be null");
            }
            this.Msg = msg;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ValidationError and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Loc
        /// </summary>
        [DataMember(Name = "loc", IsRequired = true, EmitDefaultValue = true)]
        public List<ValidationErrorLocInner> Loc { get; set; }

        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [DataMember(Name = "msg", IsRequired = true, EmitDefaultValue = true)]
        public string Msg { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidationError {\n");
            sb.Append("  Loc: ").Append(Loc).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
