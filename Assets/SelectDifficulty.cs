using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public enum SelectLevel
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public SelectLevel currentLevel;
}
