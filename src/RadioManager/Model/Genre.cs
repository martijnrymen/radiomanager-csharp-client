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
    /// Genre
    /// </summary>
    [DataContract]
    public partial class Genre :  IEquatable<Genre>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Genre" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Genre() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Genre" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="Urn">Urn.</param>
        /// <param name="ParentId">ParentId.</param>
        /// <param name="Name">Name (required).</param>
        public Genre(long? Id = default(long?), string Urn = default(string), long? ParentId = default(long?), string Name = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Genre and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Genre and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Urn = Urn;
            this.ParentId = ParentId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Urn
        /// </summary>
        [DataMember(Name="urn", EmitDefaultValue=false)]
        public string Urn { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Genre {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Urn: ").Append(Urn).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as Genre);
        }

        /// <summary>
        /// Returns true if Genre instances are equal
        /// </summary>
        /// <param name="other">Instance of Genre to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Genre other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Urn == other.Urn ||
                    this.Urn != null &&
                    this.Urn.Equals(other.Urn)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Urn != null)
                    hash = hash * 59 + this.Urn.GetHashCode();
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
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
