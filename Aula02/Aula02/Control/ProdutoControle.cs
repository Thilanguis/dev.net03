using System;
using System.Collections.Generic;
using System.Text;
using Aula02.Entities;
using System.IO;
using Newtonsoft.Json;

namespace Aula02.Control
{
    class ProdutoControle
    {
        public void ExportarDados(Produto produto)
        {
            //criando uma extensão de um arquivo .json
            StreamWriter sw = new StreamWriter("c:\\temp\\produto.json");

            //Serializa os dados do objeto JSON (objeto -> json) 
            string json = JsonConvert.SerializeObject(produto,Formatting.Indented);

            //escrevendo no arquivo
            sw.WriteLine(json);

            //fechando o arquivo
            sw.Close();

        }

        public Produto ImportarDados()
        {
            //abrindo o arquivo no modo leitura
            StreamReader sr = new StreamReader("c:\\temp\\produto.json");

            //Ler todo o arquivo e armazenar na variável json
            string json = sr.ReadToEnd();

            //fechar o arquivo
            sr.Close();

            Produto produto = JsonConvert.DeserializeObject<Produto>(json);

            return produto;
        }

    }
}
