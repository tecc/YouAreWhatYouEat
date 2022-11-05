using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.MainMenu
{
    public class TitleScreenManager : GenericScreenManager
    {

        [Header("Buttons")]
        public Button levelsButton;
        public Button creditsButton;
        public Button quitButton;

        private void Start()
        {
            creditsButton.onClick.AddListener(() => SwitchTo(creditsScreen));
            levelsButton.onClick.AddListener(() => SwitchTo(levelSelectScreen));
            quitButton.onClick.AddListener(Quit);
        }

        private void Quit()
        {
            Debug.Log("Quitting...");
            // TODO: Maybe some quit sound?
            Application.Quit();
        }
    }
}