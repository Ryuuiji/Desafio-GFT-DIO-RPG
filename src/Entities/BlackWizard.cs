namespace Projeto_de_RPG.src.Entities
{
    public class BlackWizard :Hero
    {

        public BlackWizard(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {

            return this.Name + " Lançou Magia negra";

        }
        
    }
}