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
    /// ProgramDataInput
    /// </summary>
    [DataContract]
    public partial class ProgramDataInput :  IEquatable<ProgramDataInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramDataInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProgramDataInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramDataInput" /> class.
        /// </summary>
        /// <param name="ModelTypeId">ModelTypeId (required).</param>
        /// <param name="FieldValues">FieldValues.</param>
        /// <param name="Title">Title (required).</param>
        /// <param name="Disabled">Disabled.</param>
        /// <param name="GenreId">GenreId.</param>
        /// <param name="Description">Description.</param>
        /// <param name="ShortName">ShortName.</param>
        /// <param name="MediumName">MediumName.</param>
        /// <param name="Website">Website.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Recommended">Recommended.</param>
        /// <param name="Language">Language.</param>
        /// <param name="PtyCodeId">PtyCodeId.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Presenters">Presenters.</param>
        public ProgramDataInput(long? ModelTypeId = default(long?), ProgramFieldValues FieldValues = default(ProgramFieldValues), string Title = default(string), bool? Disabled = default(bool?), long? GenreId = default(long?), string Description = default(string), string ShortName = default(string), string MediumName = default(string), string Website = default(string), string Email = default(string), bool? Recommended = default(bool?), string Language = default(string), long? PtyCodeId = default(long?), List<int?> Tags = default(List<int?>), List<int?> Presenters = default(List<int?>))
        {
            // to ensure "ModelTypeId" is required (not null)
            if (ModelTypeId == null)
            {
                throw new InvalidDataException("ModelTypeId is a required property for ProgramDataInput and cannot be null");
            }
            else
            {
                this.ModelTypeId = ModelTypeId;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for ProgramDataInput and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            this.FieldValues = FieldValues;
            this.Disabled = Disabled;
            this.GenreId = GenreId;
            this.Description = Description;
            this.ShortName = ShortName;
            this.MediumName = MediumName;
            this.Website = Website;
            this.Email = Email;
            this.Recommended = Recommended;
            this.Language = Language;
            this.PtyCodeId = PtyCodeId;
            this.Tags = Tags;
            this.Presenters = Presenters;
        }
        
        /// <summary>
        /// Gets or Sets ModelTypeId
        /// </summary>
        [DataMember(Name="model_type_id", EmitDefaultValue=false)]
        public long? ModelTypeId { get; set; }

        /// <summary>
        /// Gets or Sets FieldValues
        /// </summary>
        [DataMember(Name="field_values", EmitDefaultValue=false)]
        public ProgramFieldValues FieldValues { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Gets or Sets GenreId
        /// </summary>
        [DataMember(Name="genre_id", EmitDefaultValue=false)]
        public long? GenreId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name="short_name", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets MediumName
        /// </summary>
        [DataMember(Name="medium_name", EmitDefaultValue=false)]
        public string MediumName { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Recommended
        /// </summary>
        [DataMember(Name="recommended", EmitDefaultValue=false)]
        public bool? Recommended { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets PtyCodeId
        /// </summary>
        [DataMember(Name="pty_code_id", EmitDefaultValue=false)]
        public long? PtyCodeId { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<int?> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Presenters
        /// </summary>
        [DataMember(Name="presenters", EmitDefaultValue=false)]
        public List<int?> Presenters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramDataInput {\n");
            sb.Append("  ModelTypeId: ").Append(ModelTypeId).Append("\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  GenreId: ").Append(GenreId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  MediumName: ").Append(MediumName).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Recommended: ").Append(Recommended).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  PtyCodeId: ").Append(PtyCodeId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Presenters: ").Append(Presenters).Append("\n");
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
            return this.Equals(obj as ProgramDataInput);
        }

        /// <summary>
        /// Returns true if ProgramDataInput instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgramDataInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramDataInput other)
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
                    this.FieldValues == other.FieldValues ||
                    this.FieldValues != null &&
                    this.FieldValues.Equals(other.FieldValues)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Disabled == other.Disabled ||
                    this.Disabled != null &&
                    this.Disabled.Equals(other.Disabled)
                ) && 
                (
                    this.GenreId == other.GenreId ||
                    this.GenreId != null &&
                    this.GenreId.Equals(other.GenreId)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) && 
                (
                    this.MediumName == other.MediumName ||
                    this.MediumName != null &&
                    this.MediumName.Equals(other.MediumName)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Recommended == other.Recommended ||
                    this.Recommended != null &&
                    this.Recommended.Equals(other.Recommended)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.PtyCodeId == other.PtyCodeId ||
                    this.PtyCodeId != null &&
                    this.PtyCodeId.Equals(other.PtyCodeId)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Presenters == other.Presenters ||
                    this.Presenters != null &&
                    this.Presenters.SequenceEqual(other.Presenters)
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
                if (this.FieldValues != null)
                    hash = hash * 59 + this.FieldValues.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Disabled != null)
                    hash = hash * 59 + this.Disabled.GetHashCode();
                if (this.GenreId != null)
                    hash = hash * 59 + this.GenreId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();
                if (this.MediumName != null)
                    hash = hash * 59 + this.MediumName.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Recommended != null)
                    hash = hash * 59 + this.Recommended.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.PtyCodeId != null)
                    hash = hash * 59 + this.PtyCodeId.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Presenters != null)
                    hash = hash * 59 + this.Presenters.GetHashCode();
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
