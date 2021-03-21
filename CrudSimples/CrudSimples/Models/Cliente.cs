using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSimples.Models
{
    public class Cliente
    {

        //Usando DataAnnotations [Key] para especificar que e ClienteId é a chave, sendo assim não é necessário criar OnModelCreating no contexto
        [Key]
        public int ClienteId { get; set; }

        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
