using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_a_06
{
    internal class Ingresso
    {
        private string _nomeDoShow;
        private double _preco;
        private int _quantidadeDisponivel;

        // Cada atributo é importante para saber qual o show que vc ta comprando,
        // qual o preço do ingresso e quantos disponíveis ainda tem para a venda

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            _nomeDoShow = nomeDoShow;
            _preco = preco;
            _quantidadeDisponivel = quantidadeDisponivel;
        }
        public double AlterarPreco(double novoPreco)
        {
            _preco = novoPreco;
            return _preco;
        }

        public int AlterarQuantidade(int novaQuantidade)
        {
            _quantidadeDisponivel = novaQuantidade;
            return _quantidadeDisponivel;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Show: " + _nomeDoShow);
            Console.WriteLine("Preco do ingresso: " + _preco);
            Console.WriteLine("Quantidade disponivel: " + _quantidadeDisponivel);
        }

        // Os metodos get e set são práticos para alterar valores de atributos privados
        // pois não é possível acessá-los diretamente
        
        public string GetNomeDoShow
        {
            get { return _nomeDoShow; }
        }

        public double GetPreco
        {
            get { return _preco; }
        }

        public int GetQuantidadeDisponivel
        {
            get { return _quantidadeDisponivel; }

        }

        public string SetNomeDoShow
        {
            set { _nomeDoShow = value; }
        }

        public double SetPreco
        {
            set { _preco = value; }
        }

        public int SetQuantidadeDisponivel
        {
            set { _quantidadeDisponivel = value; }
        }

    }
}
