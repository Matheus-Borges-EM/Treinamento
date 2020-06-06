using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoSOLID
{
    public class Endereco
    {
        public int Identificador { get; set; }
        
        public string Logradouro { get; set; }
        
        public string Numero { get; set; }
        
        public string Complemento { get; set; }
        
        public Bairro Bairro{ get; set; }


    }
}
