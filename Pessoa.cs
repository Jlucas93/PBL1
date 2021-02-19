using System;
using System.Collections.Generic;

namespace PBL1
{
    public class Pessoa
    {
        //Atributos da Classe Pessoa
        public int idade { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public List<Pet> pets { get; set; }


        //Criando Construtor de Pessoa
        public Pessoa(string nome, int idade, string endereco){
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            this.pets = new List<Pet>();

            InfoPessoa();
                       
        }
        
        //Método para exibir informações do Objeto
        public void InfoPessoa(){
            Console.WriteLine("\nNome: " + nome + ";");
            Console.WriteLine("Idade: " + idade + " anos;");
            Console.WriteLine("Endereço: " + endereco + ";");
       }



    }
}