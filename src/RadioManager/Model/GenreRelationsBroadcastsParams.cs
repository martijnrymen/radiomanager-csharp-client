/* 
 * RadioManager
 *
 * RadioManager
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
    /// GenreRelationsBroadcastsParams
    /// </summary>
    [DataContract]
    public partial class GenreRelationsBroadcastsParams :  IEquatable<GenreRelationsBroadcastsParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenreRelationsBroadcastsParams" /> class.
        /// </summary>
        /// <param name="GenreId">GenreId.</param>
        public GenreRelationsBroadcastsParams(int? GenreId = default(int?))
        {
            this.GenreId = GenreId;
        }
        
        /// <summary>
        /// Gets or Sets GenreId
        /// </summary>
        [DataMember(Name="genre_id", EmitDefaultValue=false)]
        public int? GenreId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenreRelationsBroadcastsParams {\n");
            sb.Append("  GenreId: ").Append(GenreId).Append("\n");
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
            return this.Equals(obj as GenreRelationsBroadcastsParams);
        }

        /// <summary>
        /// Returns true if GenreRelationsBroadcastsParams instances are equal
        /// </summary>
        /// <param name="other">Instance of GenreRelationsBroadcastsParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenreRelationsBroadcastsParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GenreId == other.GenreId ||
                    this.GenreId != null &&
                    this.GenreId.Equals(other.GenreId)
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
                if (this.GenreId != null)
                    hash = hash * 59 + this.GenreId.GetHashCode();
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
