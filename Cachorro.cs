using System;

namespace PBL1
{
    public class Cachorro : Pet
    {
        //Atributo Unico da Classe Cachorro
        public string tamanho { get; set; }   


        //Construtor da da Classe
        public Cachorro(string nome, int idade, string raca, string vacinado, string tamanho){
            this.nome = nome;
            this.idade = idade;
            this.raca = raca;
            this.vacinado = vacinado;
            this.tamanho = tamanho;
        }
        
        //Método Para exibir informações do objeto Cachorro herdado da classe Pet
        public override string InfoPet()
        {
        return base.InfoPet() + " Tamanho: " + tamanho + ";";
        }


    }
}