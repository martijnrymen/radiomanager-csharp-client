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
    /// StoryDataInput
    /// </summary>
    [DataContract]
    public partial class StoryDataInput :  IEquatable<StoryDataInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryDataInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoryDataInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryDataInput" /> class.
        /// </summary>
        /// <param name="ModelTypeId">ModelTypeId (required).</param>
        /// <param name="Recommended">Recommended.</param>
        /// <param name="FieldValues">FieldValues.</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Description">Description.</param>
        public StoryDataInput(long? ModelTypeId = default(long?), bool? Recommended = default(bool?), Object FieldValues = default(Object), string Name = default(string), string Description = default(string))
        {
            // to ensure "ModelTypeId" is required (not null)
            if (ModelTypeId == null)
            {
                throw new InvalidDataException("ModelTypeId is a required property for StoryDataInput and cannot be null");
            }
            else
            {
                this.ModelTypeId = ModelTypeId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for StoryDataInput and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Recommended = Recommended;
            this.FieldValues = FieldValues;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets ModelTypeId
        /// </summary>
        [DataMember(Name="model_type_id", EmitDefaultValue=false)]
        public long? ModelTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Recommended
        /// </summary>
        [DataMember(Name="recommended", EmitDefaultValue=false)]
        public bool? Recommended { get; set; }

        /// <summary>
        /// Gets or Sets FieldValues
        /// </summary>
        [DataMember(Name="field_values", EmitDefaultValue=false)]
        public Object FieldValues { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoryDataInput {\n");
            sb.Append("  ModelTypeId: ").Append(ModelTypeId).Append("\n");
            sb.Append("  Recommended: ").Append(Recommended).Append("\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as StoryDataInput);
        }

        /// <summary>
        /// Returns true if StoryDataInput instances are equal
        /// </summary>
        /// <param name="other">Instance of StoryDataInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoryDataInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ModelTypeId == other.ModelTypeId ||
                    this.ModelTypeId != null &&
                    this.ModelTypeId.Equals(other.ModelTypeId)
                ) && 
                (
                    this.Recommended == other.Recommended ||
                    this.Recommended != null &&
                    this.Recommended.Equals(other.Recommended)
                ) && 
                (
                    this.FieldValues == other.FieldValues ||
                    this.FieldValues != null &&
                    this.FieldValues.Equals(other.FieldValues)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.ModelTypeId != null)
                    hash = hash * 59 + this.ModelTypeId.GetHashCode();
                if (this.Recommended != null)
                    hash = hash * 59 + this.Recommended.GetHashCode();
                if (this.FieldValues != null)
                    hash = hash * 59 + this.FieldValues.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
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
