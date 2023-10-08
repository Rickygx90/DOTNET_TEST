using System;
using Infrastructure.Contextos;

namespace Infrastructure
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Creando la DB si no existe...");
      CineContexto db = new CineContexto();
      db.Database.EnsureCreated();
      Console.WriteLine("Listo!!!!!");
      Console.ReadKey();
    }
  }
}