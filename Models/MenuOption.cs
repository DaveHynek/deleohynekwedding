using System.ComponentModel.DataAnnotations;

namespace deleohynekwedding.Models
{
    public class MenuOption
    {
        public int ID { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Caterer { get; set; }
    }
}
