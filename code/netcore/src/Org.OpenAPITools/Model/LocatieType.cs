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
    /// &lt;body&gt;&lt;p&gt;Is dit een definitie?&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Is dit een definitie?&lt;/p&gt;&lt;/body&gt;
    /// </summary>
    /// <value>&lt;body&gt;&lt;p&gt;Is dit een definitie?&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Is dit een definitie?&lt;/p&gt;&lt;/body&gt;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LocatieType
    {
        /// <summary>
        /// Enum Punt for value: punt
        /// </summary>
        [EnumMember(Value = "punt")]
        Punt = 1,

        /// <summary>
        /// Enum Ambtsgebied for value: ambtsgebied
        /// </summary>
        [EnumMember(Value = "ambtsgebied")]
        Ambtsgebied = 2,

        /// <summary>
        /// Enum Puntengroep for value: puntengroep
        /// </summary>
        [EnumMember(Value = "puntengroep")]
        Puntengroep = 3,

        /// <summary>
        /// Enum Gebied for value: gebied
        /// </summary>
        [EnumMember(Value = "gebied")]
        Gebied = 4,

        /// <summary>
        /// Enum Gebiedengroep for value: gebiedengroep
        /// </summary>
        [EnumMember(Value = "gebiedengroep")]
        Gebiedengroep = 5,

        /// <summary>
        /// Enum Lijn for value: lijn
        /// </summary>
        [EnumMember(Value = "lijn")]
        Lijn = 6,

        /// <summary>
        /// Enum Lijnengroep for value: lijnengroep
        /// </summary>
        [EnumMember(Value = "lijnengroep")]
        Lijnengroep = 7

    }

}
