using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
// CREATING A CUSTOM TYPE
public class Item
{
    public string name;
    public int ID;
    public Sprite icon;

    public enum ItemType
    {
        None,
        Weapon,
        Consumable
    }

    public ItemType itemType;
}
