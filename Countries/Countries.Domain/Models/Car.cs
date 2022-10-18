using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Countries.Domain.Models
{
    public class Car
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [JsonPropertyName("signs")]
        public string Signs { get; set; }

        [JsonPropertyName("side")]
        public string Side { get; set; }
    }
}
