using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    public List<Item> Items { get; private set; }
    //private InWorldItem WorldItem;

    public bool[] IsFull;
    public GameObject[] Itemslots;


    // Start is called before the first frame update
    void Start()
    {
        Items = new List<Item>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(Item itemToAdd)
    {
        foreach (Item currentItem in Items)
        {
            // Check if inventory has similiar items then add quantity
            if (currentItem.ItemId == itemToAdd.ItemId)
            {
                currentItem.ItemQuantity += itemToAdd.ItemQuantity;
                Destroy(itemToAdd);
                return;
            }
        }

        // If item is not yet in inventory add item
        Item duplicate = Instantiate(itemToAdd);
        Destroy(itemToAdd.gameObject);

        duplicate.transform.parent = this.transform;
        foreach(Component c in duplicate.GetComponents<Component>())
        {
            if (! (c is Item || c is Transform))
            {
                Destroy(c);
            }
        }
        Items.Add(duplicate);

        //// Check if Slots are full or not 
        //for (int i = 0; i < Itemslots.Length; i++)
        //{
        //    // If is there is a vacant slot add item
        //    if (IsFull[i] == false)
        //    {

        //        IsFull[i] = true;
        //        // 
        //        Instantiate(WorldItem.ItemPrefab, Itemslots[i].transform, false);
        //        Destroy(itemToAdd.gameObject);

        //        break;

        //    }
        //}
    }
}
