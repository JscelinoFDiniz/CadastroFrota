using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastrarFrota.Domain
{
    [Table("Car")]
    public class Car
    {
        [Key]
        public int IdCar { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo Obrigatorio")]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo Obrigatorio")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo Obrigatorio")]
        public string Chassi { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo Obrigatorio")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "*")]
        public DateTime DataFrabricacao { get; set; }

        [Required(ErrorMessage = "*")]
        public DateTime DataModelo { get; set; }
    }
}
