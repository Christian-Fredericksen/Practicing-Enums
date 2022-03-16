using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public LevelSelector currentLevel;

     private void Start()
    {
        switch(currentLevel)
        {
            case LevelSelector.Easy:
                Debug.Log("You have selected level Easy.");
                break;
            case LevelSelector.Normal:
                Debug.Log("You have selected level Normal.");
                break;
            case LevelSelector.Hard:
                Debug.Log("You have selected level Hard.");
                break;
            case LevelSelector.Expert:
                Debug.Log("You have selected level Expert.");
                break;
        }
    }
}
