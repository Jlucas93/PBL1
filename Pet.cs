using System;
using System.Collections.Generic;

namespace PBL1
{
    public class Pet
    {

        //Atributos para Criação de qualquer Pet
        public string nome { get; set; }

        public int idade { get; set; }

        public string raca { get; set; }

        public string vacinado { get; set; }


        //Método para exibir informações de Pet
         public virtual string InfoPet(){
             
             string Dados = "Nome: "+ nome +";" + " Idade: " + idade + " anos; " + " Raça: " + raca + ";" + " Vaciando: " + vacinado + ";";

             return Dados;
        }

                
    }
}