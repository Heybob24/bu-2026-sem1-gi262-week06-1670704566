using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Monster : Hero
    {
        public int baseDamage;
        private int aggroRange;
        public override void Attack(GameEntity target);
        protected void Roar();
    }
}
