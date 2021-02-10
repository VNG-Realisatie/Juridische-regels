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
    /// &lt;body&gt;&lt;p&gt;Duiding van een geografische positie. Indien er naar een locatie verwezen wordt vanuit een BevoegdGezag dan betreft dit een ambtsgebied.&lt;/p&gt;&lt;/body&gt;
    /// </summary>
    [DataContract(Name = "Locatie")]
    public partial class Locatie : IEquatable<Locatie>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GeometrieType
        /// </summary>
        [DataMember(Name = "geometrieType", EmitDefaultValue = false)]
        public GeometrieType? GeometrieType { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public LocatieType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Locatie" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Locatie() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Locatie" /> class.
        /// </summary>
        /// <param name="begindatum">begindatum (required).</param>
        /// <param name="einddatum">einddatum (required).</param>
        /// <param name="geometrie">geometrie.</param>
        /// <param name="geometrieBron">geometrieBron.</param>
        /// <param name="geometrieType">geometrieType.</param>
        /// <param name="hoogte">hoogte.</param>
        /// <param name="identificatie">identificatie (required).</param>
        /// <param name="noemer">noemer.</param>
        /// <param name="omvattendeLocatieIdentificaties">omvattendeLocatieIdentificaties.</param>
        /// <param name="type">type (required).</param>
        public Locatie(DateTime begindatum = default(DateTime), DateTime einddatum = default(DateTime), string geometrie = default(string), string geometrieBron = default(string), GeometrieType? geometrieType = default(GeometrieType?), WaardeEenheid hoogte = default(WaardeEenheid), string identificatie = default(string), string noemer = default(string), List<string> omvattendeLocatieIdentificaties = default(List<string>), LocatieType type = default(LocatieType))
        {
            this.Begindatum = begindatum;
            this.Einddatum = einddatum;
            // to ensure "identificatie" is required (not null)
            this.Identificatie = identificatie ?? throw new ArgumentNullException("identificatie is a required property for Locatie and cannot be null");
            this.Type = type;
            this.Geometrie = geometrie;
            this.GeometrieBron = geometrieBron;
            this.GeometrieType = geometrieType;
            this.Hoogte = hoogte;
            this.Noemer = noemer;
            this.OmvattendeLocatieIdentificaties = omvattendeLocatieIdentificaties;
        }

        /// <summary>
        /// Gets or Sets Begindatum
        /// </summary>
        [DataMember(Name = "begindatum", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Begindatum { get; set; }

        /// <summary>
        /// Gets or Sets Einddatum
        /// </summary>
        [DataMember(Name = "einddatum", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Einddatum { get; set; }

        /// <summary>
        /// Gets or Sets Geometrie
        /// </summary>
        [DataMember(Name = "geometrie", EmitDefaultValue = false)]
        public string Geometrie { get; set; }

        /// <summary>
        /// Gets or Sets GeometrieBron
        /// </summary>
        [DataMember(Name = "geometrieBron", EmitDefaultValue = false)]
        public string GeometrieBron { get; set; }

        /// <summary>
        /// Gets or Sets Hoogte
        /// </summary>
        [DataMember(Name = "hoogte", EmitDefaultValue = false)]
        public WaardeEenheid Hoogte { get; set; }

        /// <summary>
        /// Gets or Sets Identificatie
        /// </summary>
        [DataMember(Name = "identificatie", IsRequired = true, EmitDefaultValue = false)]
        public string Identificatie { get; set; }

        /// <summary>
        /// Gets or Sets Noemer
        /// </summary>
        [DataMember(Name = "noemer", EmitDefaultValue = false)]
        public string Noemer { get; set; }

        /// <summary>
        /// Gets or Sets OmvattendeLocatieIdentificaties
        /// </summary>
        [DataMember(Name = "omvattendeLocatieIdentificaties", EmitDefaultValue = false)]
        public List<string> OmvattendeLocatieIdentificaties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Locatie {\n");
            sb.Append("  Begindatum: ").Append(Begindatum).Append("\n");
            sb.Append("  Einddatum: ").Append(Einddatum).Append("\n");
            sb.Append("  Geometrie: ").Append(Geometrie).Append("\n");
            sb.Append("  GeometrieBron: ").Append(GeometrieBron).Append("\n");
            sb.Append("  GeometrieType: ").Append(GeometrieType).Append("\n");
            sb.Append("  Hoogte: ").Append(Hoogte).Append("\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  Noemer: ").Append(Noemer).Append("\n");
            sb.Append("  OmvattendeLocatieIdentificaties: ").Append(OmvattendeLocatieIdentificaties).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Locatie);
        }

        /// <summary>
        /// Returns true if Locatie instances are equal
        /// </summary>
        /// <param name="input">Instance of Locatie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Locatie input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Begindatum == input.Begindatum ||
                    (this.Begindatum != null &&
                    this.Begindatum.Equals(input.Begindatum))
                ) && 
                (
                    this.Einddatum == input.Einddatum ||
                    (this.Einddatum != null &&
                    this.Einddatum.Equals(input.Einddatum))
                ) && 
                (
                    this.Geometrie == input.Geometrie ||
                    (this.Geometrie != null &&
                    this.Geometrie.Equals(input.Geometrie))
                ) && 
                (
                    this.GeometrieBron == input.GeometrieBron ||
                    (this.GeometrieBron != null &&
                    this.GeometrieBron.Equals(input.GeometrieBron))
                ) && 
                (
                    this.GeometrieType == input.GeometrieType ||
                    this.GeometrieType.Equals(input.GeometrieType)
                ) && 
                (
                    this.Hoogte == input.Hoogte ||
                    (this.Hoogte != null &&
                    this.Hoogte.Equals(input.Hoogte))
                ) && 
                (
                    this.Identificatie == input.Identificatie ||
                    (this.Identificatie != null &&
                    this.Identificatie.Equals(input.Identificatie))
                ) && 
                (
                    this.Noemer == input.Noemer ||
                    (this.Noemer != null &&
                    this.Noemer.Equals(input.Noemer))
                ) && 
                (
                    this.OmvattendeLocatieIdentificaties == input.OmvattendeLocatieIdentificaties ||
                    this.OmvattendeLocatieIdentificaties != null &&
                    input.OmvattendeLocatieIdentificaties != null &&
                    this.OmvattendeLocatieIdentificaties.SequenceEqual(input.OmvattendeLocatieIdentificaties)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Begindatum != null)
                    hashCode = hashCode * 59 + this.Begindatum.GetHashCode();
                if (this.Einddatum != null)
                    hashCode = hashCode * 59 + this.Einddatum.GetHashCode();
                if (this.Geometrie != null)
                    hashCode = hashCode * 59 + this.Geometrie.GetHashCode();
                if (this.GeometrieBron != null)
                    hashCode = hashCode * 59 + this.GeometrieBron.GetHashCode();
                hashCode = hashCode * 59 + this.GeometrieType.GetHashCode();
                if (this.Hoogte != null)
                    hashCode = hashCode * 59 + this.Hoogte.GetHashCode();
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.Noemer != null)
                    hashCode = hashCode * 59 + this.Noemer.GetHashCode();
                if (this.OmvattendeLocatieIdentificaties != null)
                    hashCode = hashCode * 59 + this.OmvattendeLocatieIdentificaties.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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