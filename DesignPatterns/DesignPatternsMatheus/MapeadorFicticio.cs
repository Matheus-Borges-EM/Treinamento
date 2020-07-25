using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsMatheus
{
    public class MapeadorFicticio
    {
        private string _stringDeConexao;

        public MapeadorFicticio(string stringDeConexao)
        {
            _stringDeConexao = stringDeConexao;
        }

        public void ConsultaQualquer(string query)
        {
            Console.WriteLine("Retorno da consulta");
        }

        public void InsercaoQualquer(string query)
        {
            Console.WriteLine("Dados inseridos");
        }

        public void ExclusaoQualquer(string query)
        {
            Console.WriteLine("Dados Excluidos");
        }

        public void UpdateQualquer(string query)
        {
            Console.WriteLine("Dados atualizados");
        }
    }
}
