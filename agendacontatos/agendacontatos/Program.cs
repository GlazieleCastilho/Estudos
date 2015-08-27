using System;
using System.Collections.Generic;
using System.Text;

namespace agendacontatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inicio");

            List<Contato> contatos = new List<Contato>();
            

            Contato contato1 = new Contato("grazi", "967458458");
            
            Contato contato2 = new Contato();
            contato2.Nome = "gustavo";
            contato2.Telefone = "321564132";

            Contato contato3 = new Contato() 
            {
                Nome = "Test",
                Telefone = "13254654",
            };

            contatos.Add(contato1);
            contatos.Add(contato2);
            contatos.Add(contato3);


            Console.WriteLine("nome:{0}, tel:{1}, data:{2}", contato1.Nome, contato1.Telefone, contato1.DataDeCadastro);
            Console.WriteLine("nome:{0}, tel:{1}, data:{2}", contato2.Nome, contato2.Telefone, contato2.DataDeCadastro);
            Console.WriteLine("nome:{0}, tel:{1}, data:{2}", contato3.Nome, contato3.Telefone, contato3.DataDeCadastro);

            Console.WriteLine("fim");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Bye!");

        }
    }

    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeCadastro { get; set; }

        public Contato()
        {
            this.DataDeCadastro = DateTime.Now;
        }

        public Contato(string Nome, string Telefone)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.DataDeCadastro = DateTime.Now;
        }

    }
}
