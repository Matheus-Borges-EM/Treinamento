﻿namespace TreinamentoSOLID
{
    public class Bairro
    {
        public int Identificador { get; set; }
        
        public string Descricao { get; set; }
        
        public Cidade Cidade { get; set; }
    }
}