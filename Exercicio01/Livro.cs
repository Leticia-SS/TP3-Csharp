using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Livro
    {
        private string _nome;
        private string _autor;

        public void setName(string nome)
        {
            _nome = nome;
        }

        public void setAuthor(string autor)
        {
            _autor = autor;
        }

        public string getAuthor
        {
            get { return _autor; }
        }

        public string getName 
        { 
            get { return _nome; }
        }
    }
}
