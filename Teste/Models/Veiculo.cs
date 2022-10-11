using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Teste.Models
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }
        [Required(ErrorMessage = "Informação inválida. Verifique o que foi digitado ou se foi digitado.")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Informação inválida. Verifique o que foi digitado ou se foi digitado.")]
        public string Renavam { get; set; }
        [Required(ErrorMessage = "Informação inválida. Verifique o que foi digitado ou se foi digitado.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informação inválida. Verifique o que foi digitado ou se foi digitado.")]
        public string CPF { get; set; }
        [NotMapped]
        public IEnumerable<HttpPostedFileBase> Imagens { get; set; }
        public bool Bloqueado { get; set; }
    }
}