using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirbSimulator
{
    public class Inventory : Object
    {
        // Non-Inspector Values
        protected int Money;
        protected Dictionary<int, int> SeedInventory; // seed id, amount

        public void InitializePlayerInventory()
        {

        }

        public int GetMoney()
        {
            return Money;
        }

        public void UpdateMoney(int amount)
        {
            
        }

        public Dictionary<int, int> GetSeeds()
        {
            return SeedInventory;
        }

        public void AddSeed(int seedId, int amount)
        {

        }

        public void RemoveSeed(int seedId, int amount)
        {

        }
    }
}
