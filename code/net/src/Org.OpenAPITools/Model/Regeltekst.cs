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
    /// &lt;body&gt;&lt;p&gt;Een Regeltekst is de kleinste zelfstandige eenheid van (een of meer) bij elkaar behorende juridische regels. Deze regels horen onlosmakelijk bij elkaar en hebben gezamenlijk een werkingsgebied.&lt;/p&gt;&lt;/body&gt;
    /// </summary>
    [DataContract]
    public partial class Regeltekst :  IEquatable<Regeltekst>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Regeltekst" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Regeltekst() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Regeltekst" /> class.
        /// </summary>
        /// <param name="begindatum">begindatum (required).</param>
        /// <param name="documentComponent">documentComponent (required).</param>
        /// <param name="einddatum">einddatum (required).</param>
        /// <param name="gerelateerdeRegeltekstIdentificaties">gerelateerdeRegeltekstIdentificaties.</param>
        /// <param name="identificatie">identificatie (required).</param>
        /// <param name="laatsteWijzigingsdatum">laatsteWijzigingsdatum (required).</param>
        /// <param name="locatieIdentificaties">locatieIdentificaties (required).</param>
        /// <param name="omschrijving">omschrijving (required).</param>
        public Regeltekst(DateTime begindatum = default(DateTime), DocumentComponent documentComponent = default(DocumentComponent), DateTime einddatum = default(DateTime), List<string> gerelateerdeRegeltekstIdentificaties = default(List<string>), string identificatie = default(string), DateTime laatsteWijzigingsdatum = default(DateTime), List<string> locatieIdentificaties = default(List<string>), string omschrijving = default(string))
        {
            // to ensure "begindatum" is required (not null)
            if (begindatum == null)
            {
                throw new InvalidDataException("begindatum is a required property for Regeltekst and cannot be null");
            }
            else
            {
                this.Begindatum = begindatum;
            }
            
            // to ensure "documentComponent" is required (not null)
            if (documentComponent == null)
            {
                throw new InvalidDataException("documentComponent is a required property for Regeltekst and cannot be null");
            }
            else
            {
                this.DocumentComponent = documentComponent;
            }
            
            // to ensure "einddatum" is required (not null)
            if (einddatum == null)
            {
                throw new InvalidDataException("einddatum is a required property for Regeltekst and cannot be null");
            }
            else
            {
                this.Einddatum = einddatum;
            }
            
            // to ensure "identificatie" is required (not null)
            if (identificatie == null)
            {
                throw new InvalidDataException("identificatie is a required property for Regeltekst and cannot be null");
            }
            else
            {
                this.Identificatie = identificatie;
            }
            
            // to ensure "laatsteWijzigingsdatum" is required (not null)
            if (laatsteWijzigingsdatum == null)
            {
                throw new InvalidDataException("laatsteWijzigingsdatum is a required property for Regeltekst and cannot be null");
            }
            else
            {
                this.LaatsteWijzigingsdatum = laatsteWijzigingsdatum;
            }
            
            // to ensure "locatieIdentificaties" is required (not null)
            if (locatieIdentificaties == null)
            {
                throw new InvalidDataException("locatieIdentificaties is a required property for Regeltekst and cannot be null");
            }
            else
            {
                this.LocatieIdentificaties = locatieIdentificaties;
            }
            
            // to ensure "omschrijving" is required (not null)
            if (omschrijving == null)
            {
                throw new InvalidDataException("omschrijving is a required property for Regeltekst and cannot be null");
            }
            else
            {
                this.Omschrijving = omschrijving;
            }
            
            this.GerelateerdeRegeltekstIdentificaties = gerelateerdeRegeltekstIdentificaties;
        }
        
        /// <summary>
        /// Gets or Sets Begindatum
        /// </summary>
        [DataMember(Name="begindatum", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Begindatum { get; set; }

        /// <summary>
        /// Gets or Sets DocumentComponent
        /// </summary>
        [DataMember(Name="documentComponent", EmitDefaultValue=true)]
        public DocumentComponent DocumentComponent { get; set; }

        /// <summary>
        /// Gets or Sets Einddatum
        /// </summary>
        [DataMember(Name="einddatum", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Einddatum { get; set; }

        /// <summary>
        /// Gets or Sets GerelateerdeRegeltekstIdentificaties
        /// </summary>
        [DataMember(Name="gerelateerdeRegeltekstIdentificaties", EmitDefaultValue=false)]
        public List<string> GerelateerdeRegeltekstIdentificaties { get; set; }

        /// <summary>
        /// Gets or Sets Identificatie
        /// </summary>
        [DataMember(Name="identificatie", EmitDefaultValue=true)]
        public string Identificatie { get; set; }

        /// <summary>
        /// Gets or Sets LaatsteWijzigingsdatum
        /// </summary>
        [DataMember(Name="laatsteWijzigingsdatum", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LaatsteWijzigingsdatum { get; set; }

        /// <summary>
        /// Gets or Sets LocatieIdentificaties
        /// </summary>
        [DataMember(Name="locatieIdentificaties", EmitDefaultValue=true)]
        public List<string> LocatieIdentificaties { get; set; }

        /// <summary>
        /// Gets or Sets Omschrijving
        /// </summary>
        [DataMember(Name="omschrijving", EmitDefaultValue=true)]
        public string Omschrijving { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Regeltekst {\n");
            sb.Append("  Begindatum: ").Append(Begindatum).Append("\n");
            sb.Append("  DocumentComponent: ").Append(DocumentComponent).Append("\n");
            sb.Append("  Einddatum: ").Append(Einddatum).Append("\n");
            sb.Append("  GerelateerdeRegeltekstIdentificaties: ").Append(GerelateerdeRegeltekstIdentificaties).Append("\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  LaatsteWijzigingsdatum: ").Append(LaatsteWijzigingsdatum).Append("\n");
            sb.Append("  LocatieIdentificaties: ").Append(LocatieIdentificaties).Append("\n");
            sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
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
            return this.Equals(input as Regeltekst);
        }

        /// <summary>
        /// Returns true if Regeltekst instances are equal
        /// </summary>
        /// <param name="input">Instance of Regeltekst to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Regeltekst input)
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
                    this.DocumentComponent == input.DocumentComponent ||
                    (this.DocumentComponent != null &&
                    this.DocumentComponent.Equals(input.DocumentComponent))
                ) && 
                (
                    this.Einddatum == input.Einddatum ||
                    (this.Einddatum != null &&
                    this.Einddatum.Equals(input.Einddatum))
                ) && 
                (
                    this.GerelateerdeRegeltekstIdentificaties == input.GerelateerdeRegeltekstIdentificaties ||
                    this.GerelateerdeRegeltekstIdentificaties != null &&
                    input.GerelateerdeRegeltekstIdentificaties != null &&
                    this.GerelateerdeRegeltekstIdentificaties.SequenceEqual(input.GerelateerdeRegeltekstIdentificaties)
                ) && 
                (
                    this.Identificatie == input.Identificatie ||
                    (this.Identificatie != null &&
                    this.Identificatie.Equals(input.Identificatie))
                ) && 
                (
                    this.LaatsteWijzigingsdatum == input.LaatsteWijzigingsdatum ||
                    (this.LaatsteWijzigingsdatum != null &&
                    this.LaatsteWijzigingsdatum.Equals(input.LaatsteWijzigingsdatum))
                ) && 
                (
                    this.LocatieIdentificaties == input.LocatieIdentificaties ||
                    this.LocatieIdentificaties != null &&
                    input.LocatieIdentificaties != null &&
                    this.LocatieIdentificaties.SequenceEqual(input.LocatieIdentificaties)
                ) && 
                (
                    this.Omschrijving == input.Omschrijving ||
                    (this.Omschrijving != null &&
                    this.Omschrijving.Equals(input.Omschrijving))
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
                if (this.DocumentComponent != null)
                    hashCode = hashCode * 59 + this.DocumentComponent.GetHashCode();
                if (this.Einddatum != null)
                    hashCode = hashCode * 59 + this.Einddatum.GetHashCode();
                if (this.GerelateerdeRegeltekstIdentificaties != null)
                    hashCode = hashCode * 59 + this.GerelateerdeRegeltekstIdentificaties.GetHashCode();
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.LaatsteWijzigingsdatum != null)
                    hashCode = hashCode * 59 + this.LaatsteWijzigingsdatum.GetHashCode();
                if (this.LocatieIdentificaties != null)
                    hashCode = hashCode * 59 + this.LocatieIdentificaties.GetHashCode();
                if (this.Omschrijving != null)
                    hashCode = hashCode * 59 + this.Omschrijving.GetHashCode();
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
