using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirbSimulator
{

    public class Feeder : MonoBehaviour
    {
        // Begin Inspector Values
        public int FeederId;
        public int MaxPossibleSlots;
        public int StartingSlotAmount;
        public int MaxFeed;
        // End Inspector Values

        // Non-Inspector Values
        protected int CurrentSlotAmount;
        protected bool IsUnlocked;
        protected int CurrentFeedAmount;
        protected int CurrentFeedRarity;
        protected List<FeederLandingSpot> LandingSpots;

        public void InitializeFeeder()
        {
            CurrentSlotAmount = StartingSlotAmount;
        }

        public void UpdateFeeder(float deltaTime)
        {

        }

        public bool CanSpawn()
        {
            return false;
        }

        public void Unlock()
        {
            IsUnlocked = true;
        }

        public void Lock()
        {
            IsUnlocked = false;
        }

        public bool GetIsUnlocked()
        {
            return IsUnlocked;
        }

        public bool GetIsEmpty()
        {
            return CurrentFeedAmount <= 0;
        }

        public void FillFeeder(int feedRarity)
        {

        }

        public int GetCurrentFeedRarity()
        {
            return -1;
        }

        public void Consume(int amount)
        {

        }

        public int GetNextFreeSpot()
        {
            return -1;
        }

        public FeederLandingSpot GetLandingSpotById(int landingSpotId)
        {
            return null;
        }
    }

}
