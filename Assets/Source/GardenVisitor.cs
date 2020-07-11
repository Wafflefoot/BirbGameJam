using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirbSimulator
{
    public class GardenVisitor : MonoBehaviour
    {
        // Begin Inspector Values
        public int VisitorId;
        public string DisplayName = "Birb";
        public string DisplayDescription = "Is a birb. Look.";
        public int EatDuration;
        public int EatAmountPerSec;
        public EResourceType EatType = EResourceType.ERT_Seed;
        public int MoneyRewardAmount;
        public int SeedRewardId;
        public EResourceType RewardType = EResourceType.ERT_Money;
        public bool LeavesOnTap = true;
        public bool MustEatToTap = true;
        public int MinRarity;
        public int MaxRarity;
        public bool IsGround;
        public Sprite VisitorSprite;
        // End Inspector Values

        // Non-Inspector Values
        protected int PendingEatAmount;
        protected int ConsumedAmount;
        protected bool IsEating;
        protected float EatTimer;
        protected bool PendingLeave;
        protected bool HasBeenTapped;
        protected int SpawnerId;
        protected int FeederId;
        protected int FeederLandingSpotId;

        public void InitializeGardenVisitor()
        {

        }

        public void UpdateGardenVisitor(float deltaTime)
        {

        }

        public void UpdateEatTimer(float deltaTime)
        {

        }

        public int GetSpawnerId()
        {
            return SpawnerId;
        }

        public void SetSpawnerId(int spawnerId)
        {
            SpawnerId = spawnerId;
        }

        public int GetFeederId()
        {
            return FeederId;
        }

        public void SetFeederId(int feederId)
        {
            FeederId = feederId;
        }

        public int GetFeederLandingSpotId()
        {
            return FeederLandingSpotId;
        }

        public void SetFeederLandingSpotId(int feederLandingSpotId)
        {
            FeederLandingSpotId = feederLandingSpotId;
        }

        public int GetPendingEatAmount()
        {
            return PendingEatAmount;
        }

        public void ConsumePending()
        {

        }

        public void OnTap()
        {
            if (LeavesOnTap)
            {
                Leave();
            }
        }

        public void Leave()
        {

        }
    }

}
