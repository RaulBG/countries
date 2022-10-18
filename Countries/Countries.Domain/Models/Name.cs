using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;

namespace Countries.Domain.Models
{
    public class Name
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [JsonPropertyName("common")]
        public string Common { get; set; }

        [JsonPropertyName("official")]
        public string Official { get; set; }

        [JsonPropertyName("nativeName")]
        public ICollection<NativeNameTranslations> NativeNameTranslations { get; set; }

        public Name()
        {
            NativeNameTranslations = new List<NativeNameTranslations> ();
        }
    }
}
