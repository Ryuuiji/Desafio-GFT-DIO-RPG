using Projeto_de_RPG.src.Entities;

namespace Projeto_de_RPG

{

    class Program
    {

        static void Main(string[]args)
        {
            
            knight hero = new knight("Arus", 2 , "knight");
            Wizard wizard = new Wizard("Jennica", 23 , "White Wizard");
            BlackWizard blackwizard = new BlackWizard("Topapa", 40, "Black Wizard");
            Ninja ninja = new Ninja ("Wedge", 100 , "Ninja");

            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack(20));
            Console.WriteLine(blackwizard.Attack());
            Console.WriteLine(ninja.Attack());
            
        }
    }
}
