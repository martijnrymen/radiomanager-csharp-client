/* 
 * Pluxbox Radiomanager Client
 *
 * Pluxbox RadioManager gives you the power, flexibility and speed you always wanted in a lightweight and easy-to-use web-based radio solution. With Pluxbox RadioManager you can organise your radio workflow and automate your omnichannel communication with your listeners. We offer wide range specialised services for the radio and connections like Hybrid Radio, Visual Radio, your website and social media without losing focus on your broadcast. For more information visit https://pluxbox.com
 *
 * OpenAPI spec version: 2.0
 * Contact: support@pluxbox.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = RadioManager.Client.SwaggerDateConverter;

namespace RadioManager.Model
{
    /// <summary>
    /// NotFound
    /// </summary>
    [DataContract]
    public partial class NotFound :  IEquatable<NotFound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotFound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFound" /> class.
        /// </summary>
        /// <param name="Error">Given error, describes the problem. (required).</param>
        /// <param name="StatusCode">Assigned StatusCode, is used in order to create a relationship between Error and Response. (required).</param>
        public NotFound(string Error = default(string), long? StatusCode = default(long?))
        {
            // to ensure "Error" is required (not null)
            if (Error == null)
            {
                throw new InvalidDataException("Error is a required property for NotFound and cannot be null");
            }
            else
            {
                this.Error = Error;
            }
            // to ensure "StatusCode" is required (not null)
            if (StatusCode == null)
            {
                throw new InvalidDataException("StatusCode is a required property for NotFound and cannot be null");
            }
            else
            {
                this.StatusCode = StatusCode;
            }
        }
        
        /// <summary>
        /// Given error, describes the problem.
        /// </summary>
        /// <value>Given error, describes the problem.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Assigned StatusCode, is used in order to create a relationship between Error and Response.
        /// </summary>
        /// <value>Assigned StatusCode, is used in order to create a relationship between Error and Response.</value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public long? StatusCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotFound {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as NotFound);
        }

        /// <summary>
        /// Returns true if NotFound instances are equal
        /// </summary>
        /// <param name="other">Instance of NotFound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotFound other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}