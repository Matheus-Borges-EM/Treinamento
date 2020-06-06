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

        public Endereco(int identificador, string logradouro, string numero, string complemento, Bairro bairro)
        {
            Identificador = identificador;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
        }
    }
}
