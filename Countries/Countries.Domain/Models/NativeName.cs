using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Countries.Domain.Models
{
    public class NativeName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [JsonPropertyName("Translations")]
        public ICollection<Translation> Translations { get; set; }

        public NativeName()
        {
            Translations = new List<Translation>();
        }
    }

}
