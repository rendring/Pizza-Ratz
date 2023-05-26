using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InventoryManager : MonoBehaviour, ISerializationCallbackReceiver //this also does not work yet
{
    public InventoryDatabase Database; //this i added (xavi) it does not work yet
    public static InventoryManager Instance;
    public List <Item> Items = new List <Item>(); 
    public Transform ItemContent;
    public GameObject itemPrefab;
   

    public void Awake()
    {
        Instance = this;
    }

    public void Add (Item item)
    {
        // Add item to the list
        Items.Add(item);

        // Add UI representation of the item
        GameObject itemClone = Instantiate (itemPrefab, ItemContent);
        //Debug.Log($"{item.name}");
        itemClone.transform.GetChild(0).transform.GetComponent<TextMeshProUGUI>().text = item.name;
        itemClone.transform.GetChild(1).GetComponent<Image>().sprite = item.icon;
        
    }

    public void Remove (Item item)
    {

        Items.Remove(item);
    }

    public void ListItems()
    {
        foreach (Transform item in ItemContent) 
        {
            Destroy(item.gameObject);
        }
        
        foreach (var item in Items)
        {
            GameObject obj = Instantiate (itemPrefab, ItemContent);
            var itemName = obj.transform.Find("Items/ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("Items/Icon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }
    }

    public void OnBeforeSerialize()
    {
        
    }

    public void OnAfterDeserialize()//this does not work yet
    {
        
    }
}