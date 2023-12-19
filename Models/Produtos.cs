using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioEvertMind.Models
{
    [Table("Produto")]
    public class Produtos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código do Produto")]
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome do Produto deve ser informado")]
        [Display(Name ="Produto")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O Preço do Produto deve ser informado")]
        [Display(Name = "Preço")]
        public Decimal preco { get; set; }

    }
}
