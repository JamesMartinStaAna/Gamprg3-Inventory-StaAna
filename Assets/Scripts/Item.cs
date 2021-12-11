using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;
    public string ItemId;
    public Sprite Icon;
    public int ItemQuantity;
    public bool IsUsable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if this object as no Quantity then delete from inventory
        if (ItemQuantity <= 0)
        {
            Destroy(this);
        }
    }

    public void Use()
    {
        if (IsUsable)
        {
            //Activate 
            Debug.Log("Using item! " + Name);
            ItemQuantity -= 1;
        }
    }
}
