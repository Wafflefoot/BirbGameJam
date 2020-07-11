using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirbSimulator
{

    public class FeederLandingSpot : MonoBehaviour
    {
        //Begin Inspector Values
        public int LandingSpotId;
        public bool IsGround;
        //End Inspector Values

        //Non-Inspector Values
        protected bool IsFilled;

        public bool GetIsFilled()
        {
            return IsFilled;
        }

        public void FillSlot()
        {
            IsFilled = true;
        }

        public void EmptySlot()
        {
            IsFilled = false;
        }
    }

}