/*
 * Plan SW - Toepasbare regel SW
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// LocatieLinks
    /// </summary>
    [DataContract(Name = "Locatie_links")]
    public partial class LocatieLinks : IEquatable<LocatieLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocatieLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="omvattendeLocaties">&lt;body&gt;&lt;p&gt;Een lijn van een lijnengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een punt van een puntengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een gebied van een gebiedengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Deze relatie mag alleen lopen van een locatie van het type:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;puntengroep&lt;/li&gt;&lt;li&gt;lijnengroep&lt;/li&gt;&lt;li&gt;gebiedengroep&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;in dat geval mag deze dan ook alleen lopen naar resp. een punt, een lijn en een gebied.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;.</param>
        public LocatieLinks(HalLink self = default(HalLink), List<HalLink> omvattendeLocaties = default(List<HalLink>))
        {
            this.Self = self;
            this.OmvattendeLocaties = omvattendeLocaties;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public HalLink Self { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Een lijn van een lijnengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een punt van een puntengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een gebied van een gebiedengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Deze relatie mag alleen lopen van een locatie van het type:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;puntengroep&lt;/li&gt;&lt;li&gt;lijnengroep&lt;/li&gt;&lt;li&gt;gebiedengroep&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;in dat geval mag deze dan ook alleen lopen naar resp. een punt, een lijn en een gebied.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Een lijn van een lijnengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een punt van een puntengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een gebied van een gebiedengroep.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Deze relatie mag alleen lopen van een locatie van het type:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;puntengroep&lt;/li&gt;&lt;li&gt;lijnengroep&lt;/li&gt;&lt;li&gt;gebiedengroep&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;in dat geval mag deze dan ook alleen lopen naar resp. een punt, een lijn en een gebied.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name = "omvattendeLocaties", EmitDefaultValue = false)]
        public List<HalLink> OmvattendeLocaties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocatieLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  OmvattendeLocaties: ").Append(OmvattendeLocaties).Append("\n");
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
            return this.Equals(input as LocatieLinks);
        }

        /// <summary>
        /// Returns true if LocatieLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of LocatieLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocatieLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.OmvattendeLocaties == input.OmvattendeLocaties ||
                    this.OmvattendeLocaties != null &&
                    input.OmvattendeLocaties != null &&
                    this.OmvattendeLocaties.SequenceEqual(input.OmvattendeLocaties)
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.OmvattendeLocaties != null)
                    hashCode = hashCode * 59 + this.OmvattendeLocaties.GetHashCode();
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
