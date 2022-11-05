using UnityEngine;

namespace Game.MainMenu
{
    public abstract class GenericScreenManager : MonoBehaviour 
    {
        [Header("Objects")] 
        public GameObject titleScreen;
        public GameObject creditsScreen;
        public GameObject levelSelectScreen;

        protected void SwitchTo(GameObject obj)
        {
            bool title = titleScreen == obj, 
                credits = creditsScreen == obj,
                levelSelect = levelSelectScreen == obj;
                titleScreen.SetActive(false);
            titleScreen.SetActive(title);
            creditsScreen.SetActive(credits);
            levelSelectScreen.SetActive(levelSelect);
        }
    }
}