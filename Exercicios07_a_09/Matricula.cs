using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios07_a_09
{
    internal class Matricula
    {
        private string _NomeDoAluno;
        private string _Curso;
        private int _NumeroMatricula;
        private string _Situacao;
        private string _DataInicial;

        public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
        {
            _NomeDoAluno = nomeDoAluno;
            _Curso = curso;
            _NumeroMatricula = numeroMatricula;
            _Situacao = situacao;
            _DataInicial = dataInicial;
        }

        public void Trancar()
        {
            _Situacao = "Trancada";
        }

        public void Reativar()
        {
            _Situacao = "Ativa"; 
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Aluno: {_NomeDoAluno}\nCurso: {_Curso}\nSituação Atual: {_Situacao}\nData Inicial: {_DataInicial}");    
        }
    }
}
