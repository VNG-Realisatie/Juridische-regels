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
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.HalLink;

/**
 * ActiviteitLinks
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-05-20T08:14:08.057894Z[Etc/UTC]")
public class ActiviteitLinks {
  public static final String SERIALIZED_NAME_SELF = "self";
  @SerializedName(SERIALIZED_NAME_SELF)
  private HalLink self;

  public static final String SERIALIZED_NAME_GERELATEERDE_ACTIVITEITEN = "gerelateerdeActiviteiten";
  @SerializedName(SERIALIZED_NAME_GERELATEERDE_ACTIVITEITEN)
  private List<HalLink> gerelateerdeActiviteiten = null;

  public static final String SERIALIZED_NAME_BOVENLIGGENDE_ACTIVITEIT = "bovenliggendeActiviteit";
  @SerializedName(SERIALIZED_NAME_BOVENLIGGENDE_ACTIVITEIT)
  private Object bovenliggendeActiviteit;

  public static final String SERIALIZED_NAME_JURIDISCHE_REGELS_VOOR_IEDEREEN = "juridischeRegelsVoorIedereen";
  @SerializedName(SERIALIZED_NAME_JURIDISCHE_REGELS_VOOR_IEDEREEN)
  private List<HalLink> juridischeRegelsVoorIedereen = null;


  public ActiviteitLinks self(HalLink self) {
    
    this.self = self;
    return this;
  }

   /**
   * Get self
   * @return self
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getSelf() {
    return self;
  }


  public void setSelf(HalLink self) {
    this.self = self;
  }


  public ActiviteitLinks gerelateerdeActiviteiten(List<HalLink> gerelateerdeActiviteiten) {
    
    this.gerelateerdeActiviteiten = gerelateerdeActiviteiten;
    return this;
  }

  public ActiviteitLinks addGerelateerdeActiviteitenItem(HalLink gerelateerdeActiviteitenItem) {
    if (this.gerelateerdeActiviteiten == null) {
      this.gerelateerdeActiviteiten = new ArrayList<>();
    }
    this.gerelateerdeActiviteiten.add(gerelateerdeActiviteitenItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;De regels die gelden voor de gerelateerde activiteit(en) zijn contextueel relevant voor deze activiteit. Toelichting: Met contextueel relevant wordt bedoeld dat de regels die gelden voor de gerelateerde activiteit, binnen die gegeven context ook gelden voor deze activiteit. Bijvoorbeeld omdat de ene activiteit altijd samen met de andere activiteit(en) worden uitgevoerd en de regels van beide daarmee allebei tegelijk aan de orde zijn. Als de beschreven context waarin de regels behorende bij de gerelateerde activiteit gelden niet aan de orde is, dan gelden de regels van de gerelateerde activiteit niet. Of de context aan de orde is, is niet opgenomen als informatie. Deze relatie geeft daarom, informatiekundig gezien, aan dat elke regel die geldt voor de gerelateerde activiteit relevant kan zijn voor het uitvoeren van deze activiteit. Gerelateerde activiteiten kunnen van hetzelfde type zijn, bijvoorbeeld twee milieubelastende activiteiten, maar dat hoeft niet.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
   * @return gerelateerdeActiviteiten
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>De regels die gelden voor de gerelateerde activiteit(en) zijn contextueel relevant voor deze activiteit. Toelichting: Met contextueel relevant wordt bedoeld dat de regels die gelden voor de gerelateerde activiteit, binnen die gegeven context ook gelden voor deze activiteit. Bijvoorbeeld omdat de ene activiteit altijd samen met de andere activiteit(en) worden uitgevoerd en de regels van beide daarmee allebei tegelijk aan de orde zijn. Als de beschreven context waarin de regels behorende bij de gerelateerde activiteit gelden niet aan de orde is, dan gelden de regels van de gerelateerde activiteit niet. Of de context aan de orde is, is niet opgenomen als informatie. Deze relatie geeft daarom, informatiekundig gezien, aan dat elke regel die geldt voor de gerelateerde activiteit relevant kan zijn voor het uitvoeren van deze activiteit. Gerelateerde activiteiten kunnen van hetzelfde type zijn, bijvoorbeeld twee milieubelastende activiteiten, maar dat hoeft niet.</p></body><body><p>Een inhoudelijke toelichting op de toepassing van het informatie-element.</p></body>")

  public List<HalLink> getGerelateerdeActiviteiten() {
    return gerelateerdeActiviteiten;
  }


  public void setGerelateerdeActiviteiten(List<HalLink> gerelateerdeActiviteiten) {
    this.gerelateerdeActiviteiten = gerelateerdeActiviteiten;
  }


  public ActiviteitLinks bovenliggendeActiviteit(Object bovenliggendeActiviteit) {
    
    this.bovenliggendeActiviteit = bovenliggendeActiviteit;
    return this;
  }

   /**
   * Get bovenliggendeActiviteit
   * @return bovenliggendeActiviteit
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Object getBovenliggendeActiviteit() {
    return bovenliggendeActiviteit;
  }


  public void setBovenliggendeActiviteit(Object bovenliggendeActiviteit) {
    this.bovenliggendeActiviteit = bovenliggendeActiviteit;
  }


  public ActiviteitLinks juridischeRegelsVoorIedereen(List<HalLink> juridischeRegelsVoorIedereen) {
    
    this.juridischeRegelsVoorIedereen = juridischeRegelsVoorIedereen;
    return this;
  }

  public ActiviteitLinks addJuridischeRegelsVoorIedereenItem(HalLink juridischeRegelsVoorIedereenItem) {
    if (this.juridischeRegelsVoorIedereen == null) {
      this.juridischeRegelsVoorIedereen = new ArrayList<>();
    }
    this.juridischeRegelsVoorIedereen.add(juridischeRegelsVoorIedereenItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;Bij een regel die een activiteit vastlegt geeft deze relatie aan om welke activiteit het gaat. De bijbehorende locatie(s) waar het om gaat is/zijn bij de activiteit zelf te vinden.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
   * @return juridischeRegelsVoorIedereen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>Bij een regel die een activiteit vastlegt geeft deze relatie aan om welke activiteit het gaat. De bijbehorende locatie(s) waar het om gaat is/zijn bij de activiteit zelf te vinden.</p></body><body><p>Een inhoudelijke toelichting op de toepassing van het informatie-element.</p></body>")

  public List<HalLink> getJuridischeRegelsVoorIedereen() {
    return juridischeRegelsVoorIedereen;
  }


  public void setJuridischeRegelsVoorIedereen(List<HalLink> juridischeRegelsVoorIedereen) {
    this.juridischeRegelsVoorIedereen = juridischeRegelsVoorIedereen;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ActiviteitLinks activiteitLinks = (ActiviteitLinks) o;
    return Objects.equals(this.self, activiteitLinks.self) &&
        Objects.equals(this.gerelateerdeActiviteiten, activiteitLinks.gerelateerdeActiviteiten) &&
        Objects.equals(this.bovenliggendeActiviteit, activiteitLinks.bovenliggendeActiviteit) &&
        Objects.equals(this.juridischeRegelsVoorIedereen, activiteitLinks.juridischeRegelsVoorIedereen);
  }

  @Override
  public int hashCode() {
    return Objects.hash(self, gerelateerdeActiviteiten, bovenliggendeActiviteit, juridischeRegelsVoorIedereen);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ActiviteitLinks {\n");
    sb.append("    self: ").append(toIndentedString(self)).append("\n");
    sb.append("    gerelateerdeActiviteiten: ").append(toIndentedString(gerelateerdeActiviteiten)).append("\n");
    sb.append("    bovenliggendeActiviteit: ").append(toIndentedString(bovenliggendeActiviteit)).append("\n");
    sb.append("    juridischeRegelsVoorIedereen: ").append(toIndentedString(juridischeRegelsVoorIedereen)).append("\n");
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

