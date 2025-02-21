using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_desafio.Models.enums;

namespace api_desafio.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}