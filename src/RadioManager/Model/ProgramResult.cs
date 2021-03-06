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
    /// ProgramResult
    /// </summary>
    [DataContract]
    public partial class ProgramResult :  IEquatable<ProgramResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProgramResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramResult" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="UpdatedAt">UpdatedAt (required).</param>
        /// <param name="CreatedAt">CreatedAt (required).</param>
        /// <param name="DeletedAt">DeletedAt (required).</param>
        /// <param name="ExternalStationId">ExternalStationId.</param>
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
        /// <param name="Items">Items.</param>
        /// <param name="Blocks">Blocks.</param>
        /// <param name="Broadcasts">Broadcasts.</param>
        /// <param name="Presenters">Presenters.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="ModelType">ModelType.</param>
        public ProgramResult(long? Id = default(long?), DateTime? UpdatedAt = default(DateTime?), DateTime? CreatedAt = default(DateTime?), DateTime? DeletedAt = default(DateTime?), long? ExternalStationId = default(long?), long? ModelTypeId = default(long?), ProgramFieldValues FieldValues = default(ProgramFieldValues), string Title = default(string), bool? Disabled = default(bool?), long? GenreId = default(long?), string Description = default(string), string ShortName = default(string), string MediumName = default(string), string Website = default(string), string Email = default(string), bool? Recommended = default(bool?), string Language = default(string), long? PtyCodeId = default(long?), ProgramRelationsItems Items = default(ProgramRelationsItems), ProgramRelationsBlocks Blocks = default(ProgramRelationsBlocks), ProgramRelationsBroadcasts Broadcasts = default(ProgramRelationsBroadcasts), ProgramRelationsPresenters Presenters = default(ProgramRelationsPresenters), ProgramRelationsTags Tags = default(ProgramRelationsTags), BroadcastRelationsModelType ModelType = default(BroadcastRelationsModelType))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ProgramResult and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for ProgramResult and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for ProgramResult and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "DeletedAt" is required (not null)
            if (DeletedAt == null)
            {
                throw new InvalidDataException("DeletedAt is a required property for ProgramResult and cannot be null");
            }
            else
            {
                this.DeletedAt = DeletedAt;
            }
            // to ensure "ModelTypeId" is required (not null)
            if (ModelTypeId == null)
            {
                throw new InvalidDataException("ModelTypeId is a required property for ProgramResult and cannot be null");
            }
            else
            {
                this.ModelTypeId = ModelTypeId;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for ProgramResult and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            this.ExternalStationId = ExternalStationId;
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
            this.Items = Items;
            this.Blocks = Blocks;
            this.Broadcasts = Broadcasts;
            this.Presenters = Presenters;
            this.Tags = Tags;
            this.ModelType = ModelType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deleted_at", EmitDefaultValue=false)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExternalStationId
        /// </summary>
        [DataMember(Name="_external_station_id", EmitDefaultValue=false)]
        public long? ExternalStationId { get; set; }

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
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public ProgramRelationsItems Items { get; set; }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public ProgramRelationsBlocks Blocks { get; set; }

        /// <summary>
        /// Gets or Sets Broadcasts
        /// </summary>
        [DataMember(Name="broadcasts", EmitDefaultValue=false)]
        public ProgramRelationsBroadcasts Broadcasts { get; set; }

        /// <summary>
        /// Gets or Sets Presenters
        /// </summary>
        [DataMember(Name="presenters", EmitDefaultValue=false)]
        public ProgramRelationsPresenters Presenters { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public ProgramRelationsTags Tags { get; set; }

        /// <summary>
        /// Gets or Sets ModelType
        /// </summary>
        [DataMember(Name="model_type", EmitDefaultValue=false)]
        public BroadcastRelationsModelType ModelType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  ExternalStationId: ").Append(ExternalStationId).Append("\n");
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
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  Broadcasts: ").Append(Broadcasts).Append("\n");
            sb.Append("  Presenters: ").Append(Presenters).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
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
            return this.Equals(obj as ProgramResult);
        }

        /// <summary>
        /// Returns true if ProgramResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgramResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramResult other)
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
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.DeletedAt == other.DeletedAt ||
                    this.DeletedAt != null &&
                    this.DeletedAt.Equals(other.DeletedAt)
                ) && 
                (
                    this.ExternalStationId == other.ExternalStationId ||
                    this.ExternalStationId != null &&
                    this.ExternalStationId.Equals(other.ExternalStationId)
                ) && 
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
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.Equals(other.Items)
                ) && 
                (
                    this.Blocks == other.Blocks ||
                    this.Blocks != null &&
                    this.Blocks.Equals(other.Blocks)
                ) && 
                (
                    this.Broadcasts == other.Broadcasts ||
                    this.Broadcasts != null &&
                    this.Broadcasts.Equals(other.Broadcasts)
                ) && 
                (
                    this.Presenters == other.Presenters ||
                    this.Presenters != null &&
                    this.Presenters.Equals(other.Presenters)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) && 
                (
                    this.ModelType == other.ModelType ||
                    this.ModelType != null &&
                    this.ModelType.Equals(other.ModelType)
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
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hash = hash * 59 + this.DeletedAt.GetHashCode();
                if (this.ExternalStationId != null)
                    hash = hash * 59 + this.ExternalStationId.GetHashCode();
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
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.Blocks != null)
                    hash = hash * 59 + this.Blocks.GetHashCode();
                if (this.Broadcasts != null)
                    hash = hash * 59 + this.Broadcasts.GetHashCode();
                if (this.Presenters != null)
                    hash = hash * 59 + this.Presenters.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.ModelType != null)
                    hash = hash * 59 + this.ModelType.GetHashCode();
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
