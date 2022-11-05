using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Util
{
    public class LevelManager : UnityEngine.MonoBehaviour
    {
        [SerializeField]
        List<string> levels = new List<string>();
        

        public void LoadLevel(int levelNum)
        {
            Math.Clamp(levelNum, 0, levels.Count - 1);
            SceneManager.LoadScene(levels[levelNum]);
        }

        public bool LoadLevel(string name)
        {
            foreach (var level in levels)
            {
                if (level.Equals(name))
                {
                    SceneManager.LoadScene(level);
                    return true;
                }
            }

            return false;
        }
        
    }
}