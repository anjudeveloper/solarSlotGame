﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Mkey {
    public class LobbyController : MonoBehaviour {
        [SerializeField]
        private bool showInterstitial = false;

        #region temp vars
        private static int loadsCounter = 0;
        private Button[] buttons;
        private AdsControl GADS { get { return AdsControl.Instance; } }
        private SlotSoundController MSound { get { return SlotSoundController.Instance; } }
        #endregion temp vars

        #region regular
        void Start()
        {
            loadsCounter++;
            if (showInterstitial && loadsCounter % 3 == 0)
            {
                float volume = MSound.Volume;
                if (GADS) GADS.ShowInterstitial(()=> { MSound.SetVolume(0); }, ()=> { MSound.SetVolume(volume); });
            }
            buttons = GetComponentsInChildren<Button>();
        }
        #endregion regular

        public void SceneLoad(int scene)
        {
            SceneLoader.Instance.LoadScene(scene);
        }

        /// <summary>
        /// Set all buttons interactble = activity
        /// </summary>
        /// <param name="activity"></param>
        public void SetControlActivity(bool activity)
        {
            if (buttons == null) return;
            foreach (Button b in buttons)
            {
                if (b) b.interactable = activity;
            }
        }
    }
}