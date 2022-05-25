using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!"),
        //MinLength(3, ErrorMessage = "O campo {0} deve conter no minimo 4 caracteres"),
        //MaxLength(50, ErrorMessage = "O campo {0} deve conter no maximo 50 caracteres"),
        StringLength(50, MinimumLength = 3, ErrorMessage = "Intervalo Permitido de 3 a 50 caracteres")]
        public string Tema { get; set; }

        [Display(Name = "Qtd de pessoas"),
        Range(1, 120000, ErrorMessage = "O campo {0} de ter um intervalo de 1 a 120.000")]
        public int QtdPessoas { get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage = "Não é uma imagem Valida. (gif, jpeg, jpg, bmp ou png)")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!"),
        Phone(ErrorMessage = "O campo {0} esta esta com um numero invalido!")]
        public string Telefone { get; set; }
        
        
        [Required(ErrorMessage = "O campo {0} é obrigatorio!"),
        Display(Name = "E-mail"),
        EmailAddress(ErrorMessage = "O campo {0} deve conter um endereço de e-mail é invalido!")]
        public string Email { get; set; }
        
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedeSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}