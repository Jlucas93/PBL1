using System;
using System.Collections.Generic;

namespace PBL1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciando objetos pets e pessoa 1
            Gato g1 = new Gato("Garfield", 8, "Persian", "Vacindado");
            Cachorro c1 = new Cachorro("Snow", 4, "Chow chow", "Vacinado", "Médio");
            Cachorro c2 = new Cachorro("Luke", 1, "Buldog francês", "Não Vacinado", "Médio");
            Pessoa p1 = new Pessoa("João Lucas", 28, "Salvador ");
            
            //Instanciando objetos pets e pessoa 2
            Pessoa p2 = new Pessoa("Luis Filipe", 21, "Lauro de Freitas");
            Cachorro c3 = new Cachorro("Betoven", 7, "São Bernado", "Não Vacinado", "Grande");
            Gato g2 = new Gato("Bichano", 1, "Vira-lata", "Vacinado");

            //Criando List de pets para adicionar ao Objeto pessoa 1
            List<Pet> petsLucas = new List<Pet>();
            petsLucas.Add(c1);
            petsLucas.Add(g1);
            petsLucas.Add(c2);

            List<Pet> petsGoku = new List<Pet>();
            petsGoku.Add(g2);
            petsGoku.Add(c3);


            
            //Definindo Lista de pets igual aos novos pets criados.
            p1.pets = petsLucas;
            p2.pets = petsGoku;

            //Imprimindo tods os pets intaciados a pessoa 1
            Console.WriteLine("\nPets de " + p1.nome + ":");
             foreach(var Pet  in petsLucas){
                Console.WriteLine(Pet.InfoPet());
            }


            //Imprimindo tdos pets da pessoa 2
            Console.WriteLine("\nPets de " + p2.nome + ":");
            foreach(var Pet in petsGoku){
                Console.WriteLine(Pet.InfoPet());
            }
            
            
            
        }
    }
}
