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
    /// BroadcastRelationsItemsParams
    /// </summary>
    [DataContract]
    public partial class BroadcastRelationsItemsParams :  IEquatable<BroadcastRelationsItemsParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastRelationsItemsParams" /> class.
        /// </summary>
        /// <param name="BroadcastId">BroadcastId.</param>
        public BroadcastRelationsItemsParams(int? BroadcastId = default(int?))
        {
            this.BroadcastId = BroadcastId;
        }
        
        /// <summary>
        /// Gets or Sets BroadcastId
        /// </summary>
        [DataMember(Name="broadcast_id", EmitDefaultValue=false)]
        public int? BroadcastId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastRelationsItemsParams {\n");
            sb.Append("  BroadcastId: ").Append(BroadcastId).Append("\n");
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
            return this.Equals(obj as BroadcastRelationsItemsParams);
        }

        /// <summary>
        /// Returns true if BroadcastRelationsItemsParams instances are equal
        /// </summary>
        /// <param name="other">Instance of BroadcastRelationsItemsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BroadcastRelationsItemsParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BroadcastId == other.BroadcastId ||
                    this.BroadcastId != null &&
                    this.BroadcastId.Equals(other.BroadcastId)
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
                if (this.BroadcastId != null)
                    hash = hash * 59 + this.BroadcastId.GetHashCode();
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
