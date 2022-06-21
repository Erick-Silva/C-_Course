using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Chsarp.Classes
{
    internal class Produto
    {
        //Properties

        private string _nome;

        //Auto implemented Properties
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        //Builders
        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }



        //Custom Properties

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        /*
        public double Preco
        {
            get { return Preco; }
        }

        public double Quantidade
        {
            get { return Quantidade; }
        }
        */

        //Methods
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
