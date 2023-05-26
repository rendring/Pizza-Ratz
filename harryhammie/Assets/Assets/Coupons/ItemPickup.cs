using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
   public Item Item;
   public InventoryDatabase Database; //not working
   void Pickup()
   {
      InventoryManager.Instance.Add(Item);
      Destroy(gameObject);

   }

   private void OnMouseDown()
   {
      Pickup();
   }
}
