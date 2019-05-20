using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            //var textoComQuebraDeLinha = "minha primeira linha \n minha segunda linha";

            var enderecoDoArquivo = "contas.txt";

            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            var buffer = new byte[1024]; // É um buffer com 1kb
            var numeroDeBytesLidos = -1; // (-1) pq é um valor que nunca vai ser retornado pelo READ, pois READ só retorna numero positivo ou 0, indicando que chegou no fim.

            while(numeroDeBytesLidos != 0)
            {
                fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
} 
 