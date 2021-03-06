/*
 * Plan SW - Toepasbare regel SW
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
import org.openapitools.client.model.JuridischeRegelVoorIedereenEmbedded;
import org.openapitools.client.model.JuridischeRegelVoorIedereenLinks;

/**
 * JuridischeRegelVoorIedereenHalAllOf
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-20T08:14:08.057894Z[Etc/UTC]")
public class JuridischeRegelVoorIedereenHalAllOf {
  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private JuridischeRegelVoorIedereenLinks links;

  public static final String SERIALIZED_NAME_EMBEDDED = "_embedded";
  @SerializedName(SERIALIZED_NAME_EMBEDDED)
  private JuridischeRegelVoorIedereenEmbedded embedded;


  public JuridischeRegelVoorIedereenHalAllOf links(JuridischeRegelVoorIedereenLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public JuridischeRegelVoorIedereenLinks getLinks() {
    return links;
  }


  public void setLinks(JuridischeRegelVoorIedereenLinks links) {
    this.links = links;
  }


  public JuridischeRegelVoorIedereenHalAllOf embedded(JuridischeRegelVoorIedereenEmbedded embedded) {
    
    this.embedded = embedded;
    return this;
  }

   /**
   * Get embedded
   * @return embedded
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public JuridischeRegelVoorIedereenEmbedded getEmbedded() {
    return embedded;
  }


  public void setEmbedded(JuridischeRegelVoorIedereenEmbedded embedded) {
    this.embedded = embedded;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    JuridischeRegelVoorIedereenHalAllOf juridischeRegelVoorIedereenHalAllOf = (JuridischeRegelVoorIedereenHalAllOf) o;
    return Objects.equals(this.links, juridischeRegelVoorIedereenHalAllOf.links) &&
        Objects.equals(this.embedded, juridischeRegelVoorIedereenHalAllOf.embedded);
  }

  @Override
  public int hashCode() {
    return Objects.hash(links, embedded);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class JuridischeRegelVoorIedereenHalAllOf {\n");
    sb.append("    links: ").append(toIndentedString(links)).append("\n");
    sb.append("    embedded: ").append(toIndentedString(embedded)).append("\n");
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

