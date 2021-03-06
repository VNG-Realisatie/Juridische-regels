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
    /// RegeltekstHal
    /// </summary>
    [DataContract]
    public partial class RegeltekstHal :  IEquatable<RegeltekstHal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegeltekstHal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegeltekstHal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegeltekstHal" /> class.
        /// </summary>
        /// <param name="begindatum">begindatum.</param>
        /// <param name="documentComponent">documentComponent (required).</param>
        /// <param name="einddatum">einddatum.</param>
        /// <param name="gerelateerdeRegeltekstIdentificaties">gerelateerdeRegeltekstIdentificaties.</param>
        /// <param name="identificatie">identificatie (required).</param>
        /// <param name="laatsteWijzigingsdatum">&lt;body&gt;&lt;p&gt;De laatste datum waarop, binnen het pakket, wijzigingen zijn aangebracht aan de regeltekst.&lt;/p&gt;&lt;/body&gt; (required).</param>
        /// <param name="locatieIdentificaties">locatieIdentificaties (required).</param>
        /// <param name="omschrijving">&lt;body&gt;&lt;p&gt;De letterlijke tekst waarmee de Regeltekst is omschreven, in een artikel of een lid. Een Regeltekst is altijd één doorlopend stuk juridische tekst, welke juridische regels bevat.&lt;/p&gt;&lt;/body&gt; (required).</param>
        /// <param name="werkpakketCode">&lt;body&gt;&lt;p&gt;Een unieke aanduiding van de verzameling samenhangende activiteiten gericht op het publiceren van een nieuwe versie van een omgevingsdocument.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Er kunnen tegelijkertijd meerdere trajecten gaande zijn waarin bijvoorbeeld een omgevingsplan gewijzigd wordt, die elk leiden tot een apart te publiceren nieuwe versie van het omgevingsplan. De werkpakketcode biedt de mogelijkheid om de regelteksten te m&lt;/p&gt;&lt;/body&gt; (required).</param>
        /// <param name="links">links.</param>
        /// <param name="embedded">embedded.</param>
        public RegeltekstHal(DateTime begindatum = default(DateTime), DocumentComponent documentComponent = default(DocumentComponent), DateTime einddatum = default(DateTime), List<string> gerelateerdeRegeltekstIdentificaties = default(List<string>), string identificatie = default(string), DateTime laatsteWijzigingsdatum = default(DateTime), List<string> locatieIdentificaties = default(List<string>), string omschrijving = default(string), string werkpakketCode = default(string), RegeltekstLinks links = default(RegeltekstLinks), RegeltekstEmbedded embedded = default(RegeltekstEmbedded))
        {
            // to ensure "documentComponent" is required (not null)
            if (documentComponent == null)
            {
                throw new InvalidDataException("documentComponent is a required property for RegeltekstHal and cannot be null");
            }
            else
            {
                this.DocumentComponent = documentComponent;
            }

            // to ensure "identificatie" is required (not null)
            if (identificatie == null)
            {
                throw new InvalidDataException("identificatie is a required property for RegeltekstHal and cannot be null");
            }
            else
            {
                this.Identificatie = identificatie;
            }

            // to ensure "laatsteWijzigingsdatum" is required (not null)
            if (laatsteWijzigingsdatum == null)
            {
                throw new InvalidDataException("laatsteWijzigingsdatum is a required property for RegeltekstHal and cannot be null");
            }
            else
            {
                this.LaatsteWijzigingsdatum = laatsteWijzigingsdatum;
            }

            // to ensure "locatieIdentificaties" is required (not null)
            if (locatieIdentificaties == null)
            {
                throw new InvalidDataException("locatieIdentificaties is a required property for RegeltekstHal and cannot be null");
            }
            else
            {
                this.LocatieIdentificaties = locatieIdentificaties;
            }

            // to ensure "omschrijving" is required (not null)
            if (omschrijving == null)
            {
                throw new InvalidDataException("omschrijving is a required property for RegeltekstHal and cannot be null");
            }
            else
            {
                this.Omschrijving = omschrijving;
            }

            // to ensure "werkpakketCode" is required (not null)
            if (werkpakketCode == null)
            {
                throw new InvalidDataException("werkpakketCode is a required property for RegeltekstHal and cannot be null");
            }
            else
            {
                this.WerkpakketCode = werkpakketCode;
            }

            this.Begindatum = begindatum;
            this.Einddatum = einddatum;
            this.GerelateerdeRegeltekstIdentificaties = gerelateerdeRegeltekstIdentificaties;
            this.Links = links;
            this.Embedded = embedded;
        }

        /// <summary>
        /// Gets or Sets Begindatum
        /// </summary>
        [DataMember(Name="begindatum", EmitDefaultValue=false)]
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
        [DataMember(Name="einddatum", EmitDefaultValue=false)]
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
        /// &lt;body&gt;&lt;p&gt;De laatste datum waarop, binnen het pakket, wijzigingen zijn aangebracht aan de regeltekst.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;De laatste datum waarop, binnen het pakket, wijzigingen zijn aangebracht aan de regeltekst.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="laatsteWijzigingsdatum", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LaatsteWijzigingsdatum { get; set; }

        /// <summary>
        /// Gets or Sets LocatieIdentificaties
        /// </summary>
        [DataMember(Name="locatieIdentificaties", EmitDefaultValue=true)]
        public List<string> LocatieIdentificaties { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;De letterlijke tekst waarmee de Regeltekst is omschreven, in een artikel of een lid. Een Regeltekst is altijd één doorlopend stuk juridische tekst, welke juridische regels bevat.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;De letterlijke tekst waarmee de Regeltekst is omschreven, in een artikel of een lid. Een Regeltekst is altijd één doorlopend stuk juridische tekst, welke juridische regels bevat.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="omschrijving", EmitDefaultValue=true)]
        public string Omschrijving { get; set; }

        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Een unieke aanduiding van de verzameling samenhangende activiteiten gericht op het publiceren van een nieuwe versie van een omgevingsdocument.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Er kunnen tegelijkertijd meerdere trajecten gaande zijn waarin bijvoorbeeld een omgevingsplan gewijzigd wordt, die elk leiden tot een apart te publiceren nieuwe versie van het omgevingsplan. De werkpakketcode biedt de mogelijkheid om de regelteksten te m&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Een unieke aanduiding van de verzameling samenhangende activiteiten gericht op het publiceren van een nieuwe versie van een omgevingsdocument.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Er kunnen tegelijkertijd meerdere trajecten gaande zijn waarin bijvoorbeeld een omgevingsplan gewijzigd wordt, die elk leiden tot een apart te publiceren nieuwe versie van het omgevingsplan. De werkpakketcode biedt de mogelijkheid om de regelteksten te m&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="werkpakketCode", EmitDefaultValue=true)]
        public string WerkpakketCode { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public RegeltekstLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name="_embedded", EmitDefaultValue=false)]
        public RegeltekstEmbedded Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegeltekstHal {\n");
            sb.Append("  Begindatum: ").Append(Begindatum).Append("\n");
            sb.Append("  DocumentComponent: ").Append(DocumentComponent).Append("\n");
            sb.Append("  Einddatum: ").Append(Einddatum).Append("\n");
            sb.Append("  GerelateerdeRegeltekstIdentificaties: ").Append(GerelateerdeRegeltekstIdentificaties).Append("\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  LaatsteWijzigingsdatum: ").Append(LaatsteWijzigingsdatum).Append("\n");
            sb.Append("  LocatieIdentificaties: ").Append(LocatieIdentificaties).Append("\n");
            sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
            sb.Append("  WerkpakketCode: ").Append(WerkpakketCode).Append("\n");
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
            return this.Equals(input as RegeltekstHal);
        }

        /// <summary>
        /// Returns true if RegeltekstHal instances are equal
        /// </summary>
        /// <param name="input">Instance of RegeltekstHal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegeltekstHal input)
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
                ) && 
                (
                    this.WerkpakketCode == input.WerkpakketCode ||
                    (this.WerkpakketCode != null &&
                    this.WerkpakketCode.Equals(input.WerkpakketCode))
                ) && 
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
                if (this.WerkpakketCode != null)
                    hashCode = hashCode * 59 + this.WerkpakketCode.GetHashCode();
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

 

 

            // Omschrijving (string) minLength
            if(this.Omschrijving != null && this.Omschrijving.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Omschrijving, length must be greater than 1.", new [] { "Omschrijving" });
            }
 

            // WerkpakketCode (string) minLength
            if(this.WerkpakketCode != null && this.WerkpakketCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WerkpakketCode, length must be greater than 1.", new [] { "WerkpakketCode" });
            }
 
            yield break;
        }
    }

}
