using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;
    public string ItemId;
    public Sprite Icon;
    public int ItemQuantity;
    public int MaxItemQuantity;
    public bool IsUsable;
    public bool IsFullStack;
    [SerializeField] private Inventory playerInventory;
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerInventory = player.GetComponent<Inventory>();
    } 

    // Update is called once per frame
    void Update()
    {
        //Check if this object as no Quantity then delete from inventory
        if (ItemQuantity <= 0)
        {            
            Destroy(this.gameObject);
            playerInventory.itemsInSlots -= 1;

        }

    }

    public void Use()
    {
        if (IsUsable)
        {
            //Activate other script for health, mana etc.
            Debug.Log("Using item! " + Name);
            //Update ItemQuantity in inventory
            ItemQuantity -= 1;
            
        }
    }

    private void OnDestroy()
    {
        //Remove Object from List
        playerInventory.Items.Remove(this);
      
    }
}
