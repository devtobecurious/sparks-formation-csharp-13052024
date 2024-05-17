using System.ComponentModel.DataAnnotations.Schema;

namespace DecouverteEfCore
{
    // [Table("")]
    public class Orc
    {
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Prenom { get; set; }

        public int Force { get; set; }

        public int PointsDeVie { get; set; }

        public int Height { get; set; }
    }
}
