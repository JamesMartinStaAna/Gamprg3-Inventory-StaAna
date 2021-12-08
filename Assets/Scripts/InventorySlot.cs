using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{

    private Inventory inventory;
    public int i;

    // Start is called before the first frame update
    private void Start()
    {
        //Looks for Inventory Script in Player Object
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Check if inventory slot is empty if not set bool to false
        if (transform.childCount <= 0)
        {
            inventory.IsFull[i] = false;
        }
    }
}
