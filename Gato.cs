using System;

namespace PBL1
{
    public class Gato : Pet
    {       
        

        //Construtor para criar objeto Gato
        public Gato(string nome, int idade, string raca, string vacinado){
            this.nome = nome;
            this.idade = idade;
            this.raca = raca;
            this.vacinado = vacinado;
        }


        //Método Para exibir informações do objeto Gato herdado da classe Pet
        public override string InfoPet()
        {
         return base.InfoPet();
        }
    }
}