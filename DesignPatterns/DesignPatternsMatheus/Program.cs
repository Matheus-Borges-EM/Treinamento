using System;

namespace DesignPatternsMatheus
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.GetInstancia();
            Console.WriteLine("Banco de dados inicializado");

            Singleton.Instancia.mapeadorQualquer.InsercaoQualquer("INSERT INTO TBQUALQUER VALUES QUALQUER COISA");
            Singleton.Instancia.mapeadorQualquer.ConsultaQualquer("SELECT * FROM TBQUALQUER");
            Singleton.Instancia.mapeadorQualquer.UpdateQualquer("UPDATE TBQUALQUER QUALQUER CAMPO SET QUALQUER COISA");
            Singleton.Instancia.mapeadorQualquer.ExclusaoQualquer("DELETE FROM TBQUALQUER");

            Console.ReadKey();
        }
    }
}
