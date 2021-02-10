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
    /// &lt;body&gt;&lt;p&gt;Een limitatieve lijst met een opsomming van de mogelijke domeinwaarden van een attribuutsoort, die buiten het model in een externe waardenlijst worden beheerd.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
    /// </summary>
    [DataContract]
    public partial class Thema :  IEquatable<Thema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Thema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Thema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Thema" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="waarde">waarde (required).</param>
        public Thema(string code = default(string), string waarde = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for Thema and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            // to ensure "waarde" is required (not null)
            if (waarde == null)
            {
                throw new InvalidDataException("waarde is a required property for Thema and cannot be null");
            }
            else
            {
                this.Waarde = waarde;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Waarde
        /// </summary>
        [DataMember(Name="waarde", EmitDefaultValue=true)]
        public string Waarde { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Thema {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Waarde: ").Append(Waarde).Append("\n");
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
            return this.Equals(input as Thema);
        }

        /// <summary>
        /// Returns true if Thema instances are equal
        /// </summary>
        /// <param name="input">Instance of Thema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Thema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Waarde == input.Waarde ||
                    (this.Waarde != null &&
                    this.Waarde.Equals(input.Waarde))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Waarde != null)
                    hashCode = hashCode * 59 + this.Waarde.GetHashCode();
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
