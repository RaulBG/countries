namespace Countries.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Globalization;
    using System.Text.Json.Serialization;


    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int Id { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("tld")]
        public string Tld { get; set; }

        [JsonPropertyName("cca2")]
        public string Cca2 { get; set; }

        [JsonPropertyName("ccn3")]
        public long Ccn3 { get; set; }

        [JsonPropertyName("cca3")]
        public string Cca3 { get; set; }

        [JsonPropertyName("cioc")]
        public string Cioc { get; set; }

        [JsonPropertyName("independent")]
        public bool Independent { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("unMember")]
        public bool UnMember { get; set; }


        [JsonPropertyName("currencies")]
        public virtual Currencies Currencies { get; set; }

        [JsonPropertyName("idd")]
        public Idd Idd { get; set; }

        [JsonPropertyName("capital")]
        public string Capital { get; set; }

        [JsonPropertyName("altSpellings")]
        public string AltSpellings { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("subregion")]
        public string Subregion { get; set; }

        [JsonPropertyName("languages")]
        public virtual Languages Languages { get; set; }

        [JsonPropertyName("translations")]
        public List<Translation> Translations { get; set; }

        [JsonPropertyName("latlng")]
        public string Latlng { get; set; }

        [JsonPropertyName("landlocked")]
        public bool Landlocked { get; set; }

        [JsonPropertyName("borders")]
        public string Borders { get; set; }

        [JsonPropertyName("area")]
        public long Area { get; set; }

        [JsonPropertyName("demonyms")]
        public virtual Demonyms Demonyms { get; set; }

        [JsonPropertyName("flag")]
        public string Flag { get; set; }

        [JsonPropertyName("maps")]
        public virtual Maps Maps { get; set; }

        [JsonPropertyName("population")]
        public long Population { get; set; }

        [JsonPropertyName("gini")]
        public virtual Gini Gini { get; set; }

        [JsonPropertyName("fifa")]
        public string Fifa { get; set; }

        [JsonPropertyName("car")]
        public virtual Car Car { get; set; }

        [JsonPropertyName("timezones")]
        public string Timezones { get; set; }

        [JsonPropertyName("continents")]
        public string Continents { get; set; }

        [JsonPropertyName("flags")]
        public virtual Flags Flags { get; set; }

        [JsonPropertyName("coatOfArms")]
        public virtual CoatOfArms CoatOfArms { get; set; }

        [JsonPropertyName("startOfWeek")]
        public string StartOfWeek { get; set; }

        [JsonPropertyName("capitalInfo")]
        public virtual CapitalInfo CapitalInfo { get; set; }

        [JsonPropertyName("postalCode")]
        public  virtual PostalCode PostalCode { get; set; }
    }
}


