using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard (string Name, int Level, string HeroType){
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
        }

        public Wizard() : base (){}

        public override string Attack(){
            return this.Name + "Lançou magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }else{
                return this.Name + " Lançou Magia com força fraca com bonus de " + Bonus;
            }
        }
    }
}