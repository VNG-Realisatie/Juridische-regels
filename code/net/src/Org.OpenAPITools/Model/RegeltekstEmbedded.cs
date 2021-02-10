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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// RegeltekstEmbedded
    /// </summary>
    [DataContract]
    public partial class RegeltekstEmbedded :  IEquatable<RegeltekstEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegeltekstEmbedded" /> class.
        /// </summary>
        /// <param name="betreffendeLocaties">&lt;body&gt;&lt;p&gt;Het werkingsgebied c.q. de locatie begrenst de juridische werking van de regeltekst, in juridische zin, te weten dat deze regeltekst alleen binnen dit werkingsgebied juridische werkingskracht heeft. Het werkingsgebied van de regeltekst is altijd aanwezig. Deze is dekkend voor de locaties/gebieden die in de regeltekst zijn genoemd. Deze locaties/gebieden worden genoemd in regels die gaan over een activiteit, functie, omgevingsnorm, omgevingswaarde of beperkingengebied. Het werkingsgebied van de regeltekst is maximaal het grondgebied van het bevoegde gezag zelf.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;.</param>
        public RegeltekstEmbedded(List<LocatieHal> betreffendeLocaties = default(List<LocatieHal>))
        {
            this.BetreffendeLocaties = betreffendeLocaties;
        }
        
        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Het werkingsgebied c.q. de locatie begrenst de juridische werking van de regeltekst, in juridische zin, te weten dat deze regeltekst alleen binnen dit werkingsgebied juridische werkingskracht heeft. Het werkingsgebied van de regeltekst is altijd aanwezig. Deze is dekkend voor de locaties/gebieden die in de regeltekst zijn genoemd. Deze locaties/gebieden worden genoemd in regels die gaan over een activiteit, functie, omgevingsnorm, omgevingswaarde of beperkingengebied. Het werkingsgebied van de regeltekst is maximaal het grondgebied van het bevoegde gezag zelf.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Het werkingsgebied c.q. de locatie begrenst de juridische werking van de regeltekst, in juridische zin, te weten dat deze regeltekst alleen binnen dit werkingsgebied juridische werkingskracht heeft. Het werkingsgebied van de regeltekst is altijd aanwezig. Deze is dekkend voor de locaties/gebieden die in de regeltekst zijn genoemd. Deze locaties/gebieden worden genoemd in regels die gaan over een activiteit, functie, omgevingsnorm, omgevingswaarde of beperkingengebied. Het werkingsgebied van de regeltekst is maximaal het grondgebied van het bevoegde gezag zelf.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="betreffendeLocaties", EmitDefaultValue=false)]
        public List<LocatieHal> BetreffendeLocaties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegeltekstEmbedded {\n");
            sb.Append("  BetreffendeLocaties: ").Append(BetreffendeLocaties).Append("\n");
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
            return this.Equals(input as RegeltekstEmbedded);
        }

        /// <summary>
        /// Returns true if RegeltekstEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of RegeltekstEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegeltekstEmbedded input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BetreffendeLocaties == input.BetreffendeLocaties ||
                    this.BetreffendeLocaties != null &&
                    input.BetreffendeLocaties != null &&
                    this.BetreffendeLocaties.SequenceEqual(input.BetreffendeLocaties)
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
                if (this.BetreffendeLocaties != null)
                    hashCode = hashCode * 59 + this.BetreffendeLocaties.GetHashCode();
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
