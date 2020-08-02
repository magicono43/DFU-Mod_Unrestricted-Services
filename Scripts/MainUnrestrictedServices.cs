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
using DaggerfallWorkshop.Game.Utility.ModSupport;
using UnityEngine;

namespace UnrestrictedServices
{
    public class MainUnrestrictedServices : MonoBehaviour
    {
        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject("UnrestrictedServices");
            go.AddComponent<MainUnrestrictedServices>();

            PlayerEnterExit.OnTransitionInterior += RollServiceMember_OnTransitionInterior;
        }

        void Awake()
        {
            InitMod();

            mod.IsReady = true;
        }

        #region InitMod and Settings

        private static void InitMod()
        {
            Debug.Log("Begin mod init: UnrestrictedServices");

            Debug.Log("Finished mod init: UnrestrictedServices");
        }

        #endregion

        #region Methods and Functions

        public static void RollServiceMember_OnTransitionInterior(PlayerEnterExit.TransitionEventArgs args)
        {

        }

        #endregion

    }
}