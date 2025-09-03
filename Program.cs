using System;
using System.Collections.Generic;

namespace PetShopPOO
{
    // Classe base Animal
    public class Animal
    {
        // Propriedades com encapsulamento
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método virtual
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som genérico de animal...");
        }

        // Método para exibir informações
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }

    // Classe derivada Cachorro
    public class Cachorro : Animal
    {
        public string Raca { get; set; }

        // Construtor
        public Cachorro(string nome, int idade, string raca)
            : base(nome, idade)
        {
            Raca = raca;
        }

        // Sobrescrita do método
        public override void EmitirSom()
        {
            Console.WriteLine("Au Au!");
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"[Cachorro] Nome: {Nome}, Idade: {Idade}, Raça: {Raca}");
        }
    }

    // Classe derivada Gato
    public class Gato : Animal
    {
        public string Cor { get; set; }

        // Construtor
        public Gato(string nome, int idade, string cor)
            : base(nome, idade)
        {
            Cor = cor;
        }

        // Sobrescrita do método
        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"[Gato] Nome: {Nome}, Idade: {Idade}, Cor: {Cor}");
        }
    }

    // Classe extra (Desafio): Papagaio
    public class Papagaio : Animal
    {
        public string Origem { get; set; }

        public Papagaio(string nome, int idade, string origem)
            : base(nome, idade)
        {
            Origem = origem;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Curupaco!");
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"[Papagaio] Nome: {Nome}, Idade: {Idade}, Origem: {Origem}");
        }
    }

    // Classe PetShop
    public class PetShop
    {
        private List<Animal> animais;

        public PetShop()
        {
            animais = new List<Animal>();
        }

        public void AdicionarAnimal(Animal a)
        {
            animais.Add(a);
            Console.WriteLine($"{a.Nome} foi adicionado ao PetShop!");
        }

        public void ListarAnimais()
        {
            Console.WriteLine("\n--- Animais Cadastrados ---");
            foreach (Animal a in animais)
            {
                a.ExibirInfo();
                a.EmitirSom();
                Console.WriteLine("----------------------------");
            }
        }

        // Desafio extra: calcular média de idade
        public void CalcularMediaIdade()
        {
            if (animais.Count == 0)
            {
                Console.WriteLine("Nenhum animal cadastrado.");
                return;
            }

            double soma = 0;
            foreach (Animal a in animais)
            {
                soma += a.Idade;
            }

            double media = soma / animais.Count;
            Console.WriteLine($"Média de idade dos animais: {media:F1} anos");
        }
    }

    // Classe principal Program
    public class Program
    {
        static void Main(string[] args)
        {
            PetShop petShop = new PetShop();

            // Criando animais
            Cachorro dog1 = new Cachorro("Rex", 3, "Labrador");
            Gato cat1 = new Gato("Mimi", 2, "Branca");
            Cachorro dog2 = new Cachorro("Thor", 5, "Pastor Alemão");
            Gato cat2 = new Gato("Luna", 1, "Preta");
            Papagaio p1 = new Papagaio("Louro", 4, "Amazônia");

            // Adicionando ao PetShop
            petShop.AdicionarAnimal(dog1);
            petShop.AdicionarAnimal(cat1);
            petShop.AdicionarAnimal(dog2);
            petShop.AdicionarAnimal(cat2);
            petShop.AdicionarAnimal(p1);

            // Listar animais
            petShop.ListarAnimais();

            // Mostrar média de idades
            petShop.CalcularMediaIdade();

            Console.ReadLine();
        }
    }
}


