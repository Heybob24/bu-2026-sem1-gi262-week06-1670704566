using UnityEngine;

namespace MidtermExam.Prob01
{
    public class InventoryItem : Equipment
    {
        public string itemName;
        protected int weight;
        private int itemValue;
        public virtual Use(Character user) : void
    }
}
