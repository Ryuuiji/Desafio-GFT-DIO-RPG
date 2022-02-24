namespace Projeto_de_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia sagrada";
        }
        public  string Attack(int Bonus)
        {
            if(Bonus >6){

                 return this.Name + " Lançou Uma super magia sagrada com bonus de " + Bonus;

            }else
            {
                 return this.Name + " Lançou magia sagrada com bonus de " + Bonus ;
            }
           
        }
    }
}