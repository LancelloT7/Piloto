using System;
using System.Collections.Generic;
using System.Dynamic;


class Program
{   
     static void Main(string[] args)
    {
       Cadastrar();
    }  

    public class Produto
    {
      public string Nome {get; set;} 
      public string Idade {get; set;} 

      public Produto(string nome,string idade) 
      {
         Nome = nome;
         Idade = idade;
      }
    }

    public static void Cadastrar ()
    {
      Console.WriteLine("Escreva um nome");
      string nome = Console.ReadLine ();
      Console.WriteLine("idade?");
      string idade = Console.ReadLine ();

      Produto produto = new Produto(nome, idade);

      Console.WriteLine(produto.Nome + produto.Idade);
    }


    
    }
    
