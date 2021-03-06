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
    /// UserResultSettings
    /// </summary>
    [DataContract]
    public partial class UserResultSettings :  IEquatable<UserResultSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResultSettings" /> class.
        /// </summary>
        /// <param name="ShowSideBar">ShowSideBar.</param>
        /// <param name="ShowSocialBar">ShowSocialBar.</param>
        /// <param name="ShowCheckboxColumn">ShowCheckboxColumn.</param>
        /// <param name="ShowTimeColumn">ShowTimeColumn.</param>
        /// <param name="ShowSpeechTime">ShowSpeechTime.</param>
        /// <param name="ZoomFactor">ZoomFactor.</param>
        public UserResultSettings(bool? ShowSideBar = default(bool?), bool? ShowSocialBar = default(bool?), bool? ShowCheckboxColumn = default(bool?), bool? ShowTimeColumn = default(bool?), bool? ShowSpeechTime = default(bool?), long? ZoomFactor = default(long?))
        {
            this.ShowSideBar = ShowSideBar;
            this.ShowSocialBar = ShowSocialBar;
            this.ShowCheckboxColumn = ShowCheckboxColumn;
            this.ShowTimeColumn = ShowTimeColumn;
            this.ShowSpeechTime = ShowSpeechTime;
            this.ZoomFactor = ZoomFactor;
        }
        
        /// <summary>
        /// Gets or Sets ShowSideBar
        /// </summary>
        [DataMember(Name="showSideBar", EmitDefaultValue=false)]
        public bool? ShowSideBar { get; set; }

        /// <summary>
        /// Gets or Sets ShowSocialBar
        /// </summary>
        [DataMember(Name="showSocialBar", EmitDefaultValue=false)]
        public bool? ShowSocialBar { get; set; }

        /// <summary>
        /// Gets or Sets ShowCheckboxColumn
        /// </summary>
        [DataMember(Name="showCheckboxColumn", EmitDefaultValue=false)]
        public bool? ShowCheckboxColumn { get; set; }

        /// <summary>
        /// Gets or Sets ShowTimeColumn
        /// </summary>
        [DataMember(Name="showTimeColumn", EmitDefaultValue=false)]
        public bool? ShowTimeColumn { get; set; }

        /// <summary>
        /// Gets or Sets ShowSpeechTime
        /// </summary>
        [DataMember(Name="showSpeechTime", EmitDefaultValue=false)]
        public bool? ShowSpeechTime { get; set; }

        /// <summary>
        /// Gets or Sets ZoomFactor
        /// </summary>
        [DataMember(Name="zoomFactor", EmitDefaultValue=false)]
        public long? ZoomFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResultSettings {\n");
            sb.Append("  ShowSideBar: ").Append(ShowSideBar).Append("\n");
            sb.Append("  ShowSocialBar: ").Append(ShowSocialBar).Append("\n");
            sb.Append("  ShowCheckboxColumn: ").Append(ShowCheckboxColumn).Append("\n");
            sb.Append("  ShowTimeColumn: ").Append(ShowTimeColumn).Append("\n");
            sb.Append("  ShowSpeechTime: ").Append(ShowSpeechTime).Append("\n");
            sb.Append("  ZoomFactor: ").Append(ZoomFactor).Append("\n");
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
            return this.Equals(obj as UserResultSettings);
        }

        /// <summary>
        /// Returns true if UserResultSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of UserResultSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResultSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ShowSideBar == other.ShowSideBar ||
                    this.ShowSideBar != null &&
                    this.ShowSideBar.Equals(other.ShowSideBar)
                ) && 
                (
                    this.ShowSocialBar == other.ShowSocialBar ||
                    this.ShowSocialBar != null &&
                    this.ShowSocialBar.Equals(other.ShowSocialBar)
                ) && 
                (
                    this.ShowCheckboxColumn == other.ShowCheckboxColumn ||
                    this.ShowCheckboxColumn != null &&
                    this.ShowCheckboxColumn.Equals(other.ShowCheckboxColumn)
                ) && 
                (
                    this.ShowTimeColumn == other.ShowTimeColumn ||
                    this.ShowTimeColumn != null &&
                    this.ShowTimeColumn.Equals(other.ShowTimeColumn)
                ) && 
                (
                    this.ShowSpeechTime == other.ShowSpeechTime ||
                    this.ShowSpeechTime != null &&
                    this.ShowSpeechTime.Equals(other.ShowSpeechTime)
                ) && 
                (
                    this.ZoomFactor == other.ZoomFactor ||
                    this.ZoomFactor != null &&
                    this.ZoomFactor.Equals(other.ZoomFactor)
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
                if (this.ShowSideBar != null)
                    hash = hash * 59 + this.ShowSideBar.GetHashCode();
                if (this.ShowSocialBar != null)
                    hash = hash * 59 + this.ShowSocialBar.GetHashCode();
                if (this.ShowCheckboxColumn != null)
                    hash = hash * 59 + this.ShowCheckboxColumn.GetHashCode();
                if (this.ShowTimeColumn != null)
                    hash = hash * 59 + this.ShowTimeColumn.GetHashCode();
                if (this.ShowSpeechTime != null)
                    hash = hash * 59 + this.ShowSpeechTime.GetHashCode();
                if (this.ZoomFactor != null)
                    hash = hash * 59 + this.ZoomFactor.GetHashCode();
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
