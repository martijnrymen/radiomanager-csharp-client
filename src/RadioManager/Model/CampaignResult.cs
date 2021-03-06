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
    /// CampaignResult
    /// </summary>
    [DataContract]
    public partial class CampaignResult :  IEquatable<CampaignResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignResult" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="UpdatedAt">UpdatedAt (required).</param>
        /// <param name="CreatedAt">CreatedAt (required).</param>
        /// <param name="DeletedAt">DeletedAt (required).</param>
        /// <param name="Item">Item.</param>
        /// <param name="ExternalStationId">ExternalStationId.</param>
        /// <param name="ModelTypeId">ModelTypeId (required).</param>
        /// <param name="FieldValues">FieldValues.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Start">Start (required).</param>
        /// <param name="Stop">Stop (required).</param>
        /// <param name="Recommended">Recommended.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Items">Items.</param>
        /// <param name="ModelType">ModelType.</param>
        public CampaignResult(long? Id = default(long?), DateTime? UpdatedAt = default(DateTime?), DateTime? CreatedAt = default(DateTime?), DateTime? DeletedAt = default(DateTime?), List<Item> Item = default(List<Item>), long? ExternalStationId = default(long?), long? ModelTypeId = default(long?), List<Object> FieldValues = default(List<Object>), string Title = default(string), DateTime? Start = default(DateTime?), DateTime? Stop = default(DateTime?), bool? Recommended = default(bool?), string Description = default(string), CampaignRelationsItems Items = default(CampaignRelationsItems), BroadcastRelationsModelType ModelType = default(BroadcastRelationsModelType))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CampaignResult and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for CampaignResult and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for CampaignResult and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "DeletedAt" is required (not null)
            if (DeletedAt == null)
            {
                throw new InvalidDataException("DeletedAt is a required property for CampaignResult and cannot be null");
            }
            else
            {
                this.DeletedAt = DeletedAt;
            }
            // to ensure "ModelTypeId" is required (not null)
            if (ModelTypeId == null)
            {
                throw new InvalidDataException("ModelTypeId is a required property for CampaignResult and cannot be null");
            }
            else
            {
                this.ModelTypeId = ModelTypeId;
            }
            // to ensure "Start" is required (not null)
            if (Start == null)
            {
                throw new InvalidDataException("Start is a required property for CampaignResult and cannot be null");
            }
            else
            {
                this.Start = Start;
            }
            // to ensure "Stop" is required (not null)
            if (Stop == null)
            {
                throw new InvalidDataException("Stop is a required property for CampaignResult and cannot be null");
            }
            else
            {
                this.Stop = Stop;
            }
            this.Item = Item;
            this.ExternalStationId = ExternalStationId;
            this.FieldValues = FieldValues;
            this.Title = Title;
            this.Recommended = Recommended;
            this.Description = Description;
            this.Items = Items;
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
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public List<Item> Item { get; set; }

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
        public List<Object> FieldValues { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }

        /// <summary>
        /// Gets or Sets Stop
        /// </summary>
        [DataMember(Name="stop", EmitDefaultValue=false)]
        public DateTime? Stop { get; set; }

        /// <summary>
        /// Gets or Sets Recommended
        /// </summary>
        [DataMember(Name="recommended", EmitDefaultValue=false)]
        public bool? Recommended { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public CampaignRelationsItems Items { get; set; }

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
            sb.Append("class CampaignResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  ExternalStationId: ").Append(ExternalStationId).Append("\n");
            sb.Append("  ModelTypeId: ").Append(ModelTypeId).Append("\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Stop: ").Append(Stop).Append("\n");
            sb.Append("  Recommended: ").Append(Recommended).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(obj as CampaignResult);
        }

        /// <summary>
        /// Returns true if CampaignResult instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignResult other)
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
                    this.Item == other.Item ||
                    this.Item != null &&
                    this.Item.SequenceEqual(other.Item)
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
                    this.FieldValues.SequenceEqual(other.FieldValues)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) && 
                (
                    this.Stop == other.Stop ||
                    this.Stop != null &&
                    this.Stop.Equals(other.Stop)
                ) && 
                (
                    this.Recommended == other.Recommended ||
                    this.Recommended != null &&
                    this.Recommended.Equals(other.Recommended)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.Equals(other.Items)
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
                if (this.Item != null)
                    hash = hash * 59 + this.Item.GetHashCode();
                if (this.ExternalStationId != null)
                    hash = hash * 59 + this.ExternalStationId.GetHashCode();
                if (this.ModelTypeId != null)
                    hash = hash * 59 + this.ModelTypeId.GetHashCode();
                if (this.FieldValues != null)
                    hash = hash * 59 + this.FieldValues.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();
                if (this.Stop != null)
                    hash = hash * 59 + this.Stop.GetHashCode();
                if (this.Recommended != null)
                    hash = hash * 59 + this.Recommended.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
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
