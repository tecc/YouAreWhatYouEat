using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.MainMenu
{
    public class CreditsScreenManager : GenericScreenManager
    {
        [Header("Buttons")]
        public Button backButton;

        private void Start()
        {
            backButton.onClick.AddListener(() => SwitchTo(titleScreen));
        }
    }
}