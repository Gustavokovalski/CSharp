using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    //var linha = leitor.ReadToEnd(); USAR COM CUIDADO, pois faz a leitura ate o fim.
                    //var linha = leitor.Read(); retorna int, o primeiro byte.
                    Console.WriteLine(linha);
                }
            }




            Console.ReadLine();
        }

    }
}
