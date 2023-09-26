using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace filmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {


        [Required(ErrorMessage = "o campo titulo e obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "o campo Diretor e obrigatorio")]
        public string Diretor { get; set; }

        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "o campo Duracao deve conter de 1 a 600")]
        public int Duracao { get; set; }

    }
}
