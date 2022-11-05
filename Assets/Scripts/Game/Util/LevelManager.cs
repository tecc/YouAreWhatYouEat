using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Util
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] List<string> levels = new();


        public void LoadLevel(int levelNum)
        {
            Math.Clamp(levelNum, 0, levels.Count - 1);
            SceneManager.LoadScene(levels[levelNum]);
        }

        public bool LoadLevel(string levelName)
        {
            foreach (var level in levels.Where(level => level.Equals(levelName)))
            {
                SceneManager.LoadScene(level);
                return true;
            }

            return false;
        }
    }
}