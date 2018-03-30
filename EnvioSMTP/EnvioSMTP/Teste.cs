using System;

namespace EnvioSMTP
{
    public class Teste
    {
        public static void Main(string[] args)
        {
            try
            {
                EnviarEmail.EnviarMessagemEmail(
                    "REMETENTE",
                    "DESTINARIO",
                    "TITULO",
                    "MENSAGEM EM HTML"
                    );
                Console.WriteLine("CONCLUIDO");
            }
            catch
            {
                Console.WriteLine("ERRO");
            }
            Console.WriteLine("Aperta qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
}
