using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeEmpresasLibrary;
using CadastroEmpresasLibrary;
using CadastroDeEmpresas;
using CadastroEmpresasLibrary.Classes;

namespace ConsoleSandBox
{
    public class Program
    {
        //CLASSE APENAS PARA TESTES ::..
        public static void Main(string[] args)
        {
            PessoaFisica ps = new PessoaFisica();
            ps.Nome = "nesio";
            ps.Email = "nesio@gmail.com";
            ps.CPF = "49036879884";
            ps.Celular = "123213213";
            ps.Telefone = "1231412";
            ps.DataNascimento = DateTime.Now;
            ps.Dispose();



        }
    }
}
