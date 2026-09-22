using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Weapon
    {
        public int extraDamage;
        private float criticalChance;
        public override void Equip(Hero hero);
        public void Polish();
    }
}
