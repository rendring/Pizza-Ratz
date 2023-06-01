using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
   public Item Item;

    private void Start()
    {
        DontDestroyOnLoad(this);

    }
    public void Update()
    {
        if (Item.itemIsPickedUp == 1)
        {
            Destroy(gameObject);
            InventoryManager.Instance.Add(Item);
            Debug.Log("item is stored in the inventory");
        }
        else 
        {

        }
    }

    public void Pickup()
   {
      InventoryManager.Instance.Add(Item);
      Destroy(gameObject);
        Item.itemIsPickedUp = Item.itemIsPickedUp + 1;
        Debug.Log("item is picking up");
   }

   private void OnMouseDown()
   {
      Pickup();
   }
}
