using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        public string id;
        private Vector3 position;
        protected int health;
        public virtual void Update();
        public virtual void TakeDamage(int damage);
        private void MoveTowards(Vector3 direction);







    }
}
