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
    /// JuridischeRegelVoorIedereenEmbedded
    /// </summary>
    [DataContract(Name = "JuridischeRegelVoorIedereen_embedded")]
    public partial class JuridischeRegelVoorIedereenEmbedded : IEquatable<JuridischeRegelVoorIedereenEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JuridischeRegelVoorIedereenEmbedded" /> class.
        /// </summary>
        /// <param name="gedefinieerdeLocaties">&lt;body&gt;&lt;p&gt;De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;.</param>
        /// <param name="omvattendeRegeltekst">omvattendeRegeltekst.</param>
        public JuridischeRegelVoorIedereenEmbedded(List<LocatieHal> gedefinieerdeLocaties = default(List<LocatieHal>), RegeltekstHal omvattendeRegeltekst = default(RegeltekstHal))
        {
            this.GedefinieerdeLocaties = gedefinieerdeLocaties;
            this.OmvattendeRegeltekst = omvattendeRegeltekst;
        }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name = "gedefinieerdeLocaties", EmitDefaultValue = false)]
        public List<LocatieHal> GedefinieerdeLocaties { get; set; }

        /// <summary>
        /// Gets or Sets OmvattendeRegeltekst
        /// </summary>
        [DataMember(Name = "omvattendeRegeltekst", EmitDefaultValue = false)]
        public RegeltekstHal OmvattendeRegeltekst { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JuridischeRegelVoorIedereenEmbedded {\n");
            sb.Append("  GedefinieerdeLocaties: ").Append(GedefinieerdeLocaties).Append("\n");
            sb.Append("  OmvattendeRegeltekst: ").Append(OmvattendeRegeltekst).Append("\n");
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
            return this.Equals(input as JuridischeRegelVoorIedereenEmbedded);
        }

        /// <summary>
        /// Returns true if JuridischeRegelVoorIedereenEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of JuridischeRegelVoorIedereenEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JuridischeRegelVoorIedereenEmbedded input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GedefinieerdeLocaties == input.GedefinieerdeLocaties ||
                    this.GedefinieerdeLocaties != null &&
                    input.GedefinieerdeLocaties != null &&
                    this.GedefinieerdeLocaties.SequenceEqual(input.GedefinieerdeLocaties)
                ) && 
                (
                    this.OmvattendeRegeltekst == input.OmvattendeRegeltekst ||
                    (this.OmvattendeRegeltekst != null &&
                    this.OmvattendeRegeltekst.Equals(input.OmvattendeRegeltekst))
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
                if (this.GedefinieerdeLocaties != null)
                    hashCode = hashCode * 59 + this.GedefinieerdeLocaties.GetHashCode();
                if (this.OmvattendeRegeltekst != null)
                    hashCode = hashCode * 59 + this.OmvattendeRegeltekst.GetHashCode();
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
