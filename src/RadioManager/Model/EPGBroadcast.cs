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
    /// EPGBroadcast
    /// </summary>
    [DataContract]
    public partial class EPGBroadcast :  IEquatable<EPGBroadcast>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EPGBroadcast" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EPGBroadcast() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EPGBroadcast" /> class.
        /// </summary>
        /// <param name="_20160111">_20160111 (required).</param>
        /// <param name="NextPageUrl">NextPageUrl (required) (default to &quot;https://raidiomanager.pluxbox.com/api/v1/broadcasts/epg/{identifier}/2016-01-12&quot;).</param>
        /// <param name="PrevPageUrl">PrevPageUrl (required) (default to &quot;https://raidiomanager.pluxbox.com/pb/api/v1/broadcasts/epg/{identifier}/2016-01-10&quot;).</param>
        public EPGBroadcast(List<BroadcastResult> _20160111 = default(List<BroadcastResult>), string NextPageUrl = "https://raidiomanager.pluxbox.com/api/v1/broadcasts/epg/{identifier}/2016-01-12", string PrevPageUrl = "https://raidiomanager.pluxbox.com/pb/api/v1/broadcasts/epg/{identifier}/2016-01-10")
        {
            // to ensure "_20160111" is required (not null)
            if (_20160111 == null)
            {
                throw new InvalidDataException("_20160111 is a required property for EPGBroadcast and cannot be null");
            }
            else
            {
                this._20160111 = _20160111;
            }
            // to ensure "NextPageUrl" is required (not null)
            if (NextPageUrl == null)
            {
                throw new InvalidDataException("NextPageUrl is a required property for EPGBroadcast and cannot be null");
            }
            else
            {
                this.NextPageUrl = NextPageUrl;
            }
            // to ensure "PrevPageUrl" is required (not null)
            if (PrevPageUrl == null)
            {
                throw new InvalidDataException("PrevPageUrl is a required property for EPGBroadcast and cannot be null");
            }
            else
            {
                this.PrevPageUrl = PrevPageUrl;
            }
        }
        
        /// <summary>
        /// Gets or Sets _20160111
        /// </summary>
        [DataMember(Name="2016-01-11", EmitDefaultValue=false)]
        public List<BroadcastResult> _20160111 { get; set; }

        /// <summary>
        /// Gets or Sets NextPageUrl
        /// </summary>
        [DataMember(Name="next_page_url", EmitDefaultValue=false)]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Gets or Sets PrevPageUrl
        /// </summary>
        [DataMember(Name="prev_page_url", EmitDefaultValue=false)]
        public string PrevPageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EPGBroadcast {\n");
            sb.Append("  _20160111: ").Append(_20160111).Append("\n");
            sb.Append("  NextPageUrl: ").Append(NextPageUrl).Append("\n");
            sb.Append("  PrevPageUrl: ").Append(PrevPageUrl).Append("\n");
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
            return this.Equals(obj as EPGBroadcast);
        }

        /// <summary>
        /// Returns true if EPGBroadcast instances are equal
        /// </summary>
        /// <param name="other">Instance of EPGBroadcast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EPGBroadcast other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._20160111 == other._20160111 ||
                    this._20160111 != null &&
                    this._20160111.SequenceEqual(other._20160111)
                ) && 
                (
                    this.NextPageUrl == other.NextPageUrl ||
                    this.NextPageUrl != null &&
                    this.NextPageUrl.Equals(other.NextPageUrl)
                ) && 
                (
                    this.PrevPageUrl == other.PrevPageUrl ||
                    this.PrevPageUrl != null &&
                    this.PrevPageUrl.Equals(other.PrevPageUrl)
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
                if (this._20160111 != null)
                    hash = hash * 59 + this._20160111.GetHashCode();
                if (this.NextPageUrl != null)
                    hash = hash * 59 + this.NextPageUrl.GetHashCode();
                if (this.PrevPageUrl != null)
                    hash = hash * 59 + this.PrevPageUrl.GetHashCode();
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
