using Aula02.Entities;
using System;
using Aula02.Control;
using System.IO;


namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto (1, "Gabriel" ,12.23m ,4);
            ProdutoControle produtoControle = new ProdutoControle();

            /*Console.WriteLine("\nDADOS DO PRODUTO: \n");
            Console.WriteLine("Código ..........:" + p1.IdProduto);
            Console.WriteLine("Nome ..........:" + p1.Nome);
            Console.WriteLine("Preço ..........:" + p1.Preco);
            Console.WriteLine("Quantidade ..........:" + p1.Quantidade);*/

            #region ExportarDados
            try //tentativa
            {
                produtocontrole.ExportarDados(p1);
                Console.WriteLine("\nDados gravados com sucesso\n");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Diretório não encontrado:" + e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("\nAcesso negado ao diretório:" + e.Message);
            }
            catch (Exception e) //captura e excessão genérica
            {
                Console.WriteLine("\nOcorreu um erro:" + e.Message);
            }
            #endregion

            #region ImportarDados
            Produto registro = produtoControle.ImportarDados();

            Console.WriteLine("\nDADOS IMPORTADOS DO ARQUIVO: ");
            Console.WriteLine($"Id: {registro.IdProduto}, " +
                              $"Nome: {registro.Nome}, " +
                              $"Preco: {registro.Preco}," +
                              $"Quantidade:{registro.Quantidade}");
            Console.ReadKey();
        }
    }
}
