/*
 * Plan SW - Toepasbare regel SW
 *
 * Nog in te voorzien
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: robert.melskens@vng.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// RegeltekstHalAllOf
    /// </summary>
    [DataContract(Name = "RegeltekstHal_allOf")]
    public partial class RegeltekstHalAllOf : IEquatable<RegeltekstHalAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegeltekstHalAllOf" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="embedded">embedded.</param>
        public RegeltekstHalAllOf(RegeltekstLinks links = default(RegeltekstLinks), RegeltekstEmbedded embedded = default(RegeltekstEmbedded))
        {
            this.Links = links;
            this.Embedded = embedded;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public RegeltekstLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name = "_embedded", EmitDefaultValue = false)]
        public RegeltekstEmbedded Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegeltekstHalAllOf {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegeltekstHalAllOf);
        }

        /// <summary>
        /// Returns true if RegeltekstHalAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of RegeltekstHalAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegeltekstHalAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Embedded == input.Embedded ||
                    (this.Embedded != null &&
                    this.Embedded.Equals(input.Embedded))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Embedded != null)
                    hashCode = hashCode * 59 + this.Embedded.GetHashCode();
                return hashCode;
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
