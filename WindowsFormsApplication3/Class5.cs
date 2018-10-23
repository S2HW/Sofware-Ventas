using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApplication3
{
    public abstract class Contenido1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int codigoprod { get; set; }
        public virtual string nombre { get; set; }
        public virtual int precio { get; set; }

        public abstract string obtenerTexto();

    }
}
