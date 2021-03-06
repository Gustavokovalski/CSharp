﻿using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void LidandoComFileStreamDiretamente()
        {
            //var textoComQuebraDeLinha = "minha primeira linha \n minha segunda linha";

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; // É um buffer com 1kb

                var numeroDeBytesLidos = -1; // (-1) pq é um valor que nunca vai ser retornado pelo READ, pois READ só retorna numero positivo ou 0, indicando que chegou no fim.

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"Bytes lidos:{numeroDeBytesLidos}");
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

            }

        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
}