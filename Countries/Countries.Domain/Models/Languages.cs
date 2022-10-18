using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Countries.Domain.Models
{

    public class Languages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [JsonPropertyName("aym")]
        public string Aym { get; set; }

        [JsonPropertyName("que")]
        public string Que { get; set; }

        [JsonPropertyName("spa")]
        public string Spa { get; set; }
    }
}
