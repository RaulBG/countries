using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Countries.Domain.Models
{
    public class Maps
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [JsonPropertyName("googleMaps")]
        public Uri GoogleMaps { get; set; }

        [JsonPropertyName("openStreetMaps")]
        public Uri OpenStreetMaps { get; set; }
    }
}
