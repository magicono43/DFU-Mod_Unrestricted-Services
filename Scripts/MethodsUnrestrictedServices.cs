// Project:         UnrestrictedServices mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2020 Kirk.O
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Kirk.O
// Created On: 	    8/1/2020, 7:55 PM
// Last Edit:		8/1/2020, 8:00 PM
// Version:			1.00
// Special Thanks:  Hazelnut
// Modifier:			

using DaggerfallWorkshop;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Utility;
using UnityEngine;

namespace UnrestrictedServices
{
    public class MethodsUnrestrictedServices
    {
        #region Methods and Functions

        public static void RollServiceMember_OnTransitionInterior(PlayerEnterExit.TransitionEventArgs args)
        {
            bool validBuilding = ValidBuildingCheck();
            bool newBuilding = NewBuildingCheck(validBuilding);
            RollServiceNPC(newBuilding); // Will equal an object later, object will be returned from this.
        }

        // WIP, Rolls if a valid building will spawn a service NPC and returns what type will spawn (as an appropriate object, void just for now.)
        public static void RollServiceNPC(bool newBuilding)
        {
            int texArchive = 184;
            int texRecord = 1;
            string serviceFlat = "Service Person Flat";
            GameObject node = new GameObject(serviceFlat);
            GameObject go = null;
            Vector3 billboardPosition = new Vector3(10, 0, 10) * MeshReader.GlobalScale;

            // Spawn billboard gameobject
            go = GameObjectHelper.CreateDaggerfallBillboardGameObject(texArchive, texRecord, node.transform); // This has something to do with creating a Flat/billboard NPC in the world, play around more and test.

            // Set position
            DaggerfallBillboard dfBillboard = go.GetComponent<DaggerfallBillboard>();
            go.transform.position = billboardPosition;
            go.transform.position += new Vector3(0, dfBillboard.Summary.Size.y / 2, 0);
        }

        // WIP, Checks that the building that IS valid, also does not currently have a service NPC in it, or has already had this spawn event happen within the minimum "reset" time.
        public static bool NewBuildingCheck(bool validBuilding)
        {
            return true;
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