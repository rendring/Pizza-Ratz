using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu (fileName = "New Item" , menuName = "Item/Create New Item")]

public class Item : ScriptableObject

{
    public InventoryDatabase database;//does not work yet
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;

  
}
