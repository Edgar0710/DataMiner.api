using System;
using System.Collections.Generic;
using System.Text;

namespace DataMiner.Model.Models
{
    public class FormModel
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public List<Respuesta> Respuestas{ get; set;}
    }
}
