using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CriarArquivoComWriter();
            Console.WriteLine("Aplicação finalizada. . .");


            Console.ReadLine();


            //var enderecoDoArquivo = "contas.txt";

            //using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            //using (var leitor = new StreamReader(fluxoDeArquivo))
            //{
            //    while (!leitor.EndOfStream)
            //    {
            //        var linha = leitor.ReadLine();
            //        //var linha = leitor.ReadToEnd(); USAR COM CUIDADO, pois faz a leitura ate o fim.
            //        //var linha = leitor.Read(); retorna int, o primeiro byte.

            //        var contaCorrente = ConverterStringParaContaCorrente(linha);
            //        var msg = $"{contaCorrente.Titular.Nome} : Conta número{contaCorrente.Numero}" +
            //            $", ag.{contaCorrente.Agencia}" +
            //            $". Saldo: {contaCorrente.Saldo}";

            //        Console.WriteLine(msg);
            //    //      //  Console.WriteLine(linha);
            //        }
            //    }

            //    Console.ReadLine();
            //}
            //    static ContaCorrente ConverterStringParaContaCorrente(string linha)
            //{
            //    string[] campos = linha.Split(' '); // Split => metodo q quebra uma string a partir do caractere separador definido
            //    var agencia = campos[0];
            //    var numero = campos[1];
            //    var saldo = campos.Replace(',');
            //    var nomeTitular = campos[3];

            //    var agenciaComoInt = int.Parse(agencia);
            //    var numeroComoInt = int.Parse(numero);
            //    var saldoComoDouble = double.Parse(saldo);
            //    var titular = new Cliente();
            //    titular.Nome = nomeTitular;

            //    var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            //    resultado.Depositar(saldoComoDouble);
            //    resultado.Titular = titular;

            //    return resultado;
            //}


        }
    }
}
