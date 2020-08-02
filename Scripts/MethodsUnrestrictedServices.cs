// Project:         UnrestrictedServices mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2020 Kirk.O
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Kirk.O
// Created On: 	    8/1/2020, 7:55 PM
// Last Edit:		8/1/2020, 8:00 PM
// Version:			1.00
// Special Thanks:  Hazelnut
// Modifier:			

using DaggerfallWorkshop.Game;
using UnityEngine;

namespace UnrestrictedServices
{
    public class MethodsUnrestrictedServices
    {
        #region Methods and Functions

        public static void RollServiceMember_OnTransitionInterior(PlayerEnterExit.TransitionEventArgs args)
        {
            bool validBuilding = ValidBuildingCheck();
            // Work on continuing to build on this tomorrow, good start thus far.
        }

        // Checks that the building just entered in a valid building in which to potentially spawn a service providing NPC
        public static bool ValidBuildingCheck()
        {
            if (GameManager.Instance.PlayerEnterExit.BuildingDiscoveryData.buildingType == DaggerfallConnect.DFLocation.BuildingTypes.Tavern) // Checks that the building just entered is a tavern.
            {
                Debug.Log("You Just Entered A Tavern, Good Job!...");
                return true;
            }
            else
            {
                Debug.Log("You Just Entered Something Other Than A Tavern, Nice Job Idiot!");
                return false;
            }
        }

        #endregion

    }
}