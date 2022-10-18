using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Countries.Domain.Models
{
    public class Idd
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [JsonPropertyName("root")]
        public string Root { get; set; }

        [JsonPropertyName("suffixes")]
        public string Suffixes { get; set; }
    }
}
