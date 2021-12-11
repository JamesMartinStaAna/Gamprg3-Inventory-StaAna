using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //DEBUG TEST
    public Item ItemToPickup;
    public Inventory Inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && ItemToPickup != null && Inventory.IsFull == false) 
        {
            Inventory.AddItem(ItemToPickup);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        //Assign pickup object on collision
        if (collision.gameObject.CompareTag("Item"))
        {
            ItemToPickup = collision.gameObject.GetComponent<Item>();
               
        }
    }

}
