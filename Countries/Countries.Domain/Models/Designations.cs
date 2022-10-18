using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Countries.Domain.Models
{
    public class Designations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }


        public virtual ICollection<DesignationsAttributes> DesignationsAttributes { get; set; }


        public Designations()
        {            
            DesignationsAttributes=new List<DesignationsAttributes>();
        }

    }
}
