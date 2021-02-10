/*
 * Plan SW - Toepasbare regel SW
 * Nog in te voorzien
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: robert.melskens@vng.nl
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * &lt;body&gt;&lt;p&gt;Een lijst met een opsomming van de mogelijke domeinwaarden van een attribuutsoort, die buiten het model in een externe waardenlijst worden beheerd.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
 */
@ApiModel(description = "<body><p>Een lijst met een opsomming van de mogelijke domeinwaarden van een attribuutsoort, die buiten het model in een externe waardenlijst worden beheerd.</p></body><body><p>Een inhoudelijke toelichting op de toepassing van het informatie-element.</p></body>")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-02-10T09:19:26.366Z[Etc/UTC]")
public class Idealisatie {
  public static final String SERIALIZED_NAME_CODE = "code";
  @SerializedName(SERIALIZED_NAME_CODE)
  private String code;

  public static final String SERIALIZED_NAME_WAARDE = "waarde";
  @SerializedName(SERIALIZED_NAME_WAARDE)
  private String waarde;


  public Idealisatie code(String code) {
    
    this.code = code;
    return this;
  }

   /**
   * Get code
   * @return code
  **/
  @ApiModelProperty(required = true, value = "")

  public String getCode() {
    return code;
  }


  public void setCode(String code) {
    this.code = code;
  }


  public Idealisatie waarde(String waarde) {
    
    this.waarde = waarde;
    return this;
  }

   /**
   * Get waarde
   * @return waarde
  **/
  @ApiModelProperty(required = true, value = "")

  public String getWaarde() {
    return waarde;
  }


  public void setWaarde(String waarde) {
    this.waarde = waarde;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Idealisatie idealisatie = (Idealisatie) o;
    return Objects.equals(this.code, idealisatie.code) &&
        Objects.equals(this.waarde, idealisatie.waarde);
  }

  @Override
  public int hashCode() {
    return Objects.hash(code, waarde);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Idealisatie {\n");
    sb.append("    code: ").append(toIndentedString(code)).append("\n");
    sb.append("    waarde: ").append(toIndentedString(waarde)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

