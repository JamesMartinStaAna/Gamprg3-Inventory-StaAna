using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIController : MonoBehaviour
{
    public Inventory PlayerInventory;
    public RectTransform GridLayout;

    public List<ItemUIController> ItemDisplays;
    public GameObject InventoryUI;
    public GameObject ItemHolderPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        //Check if there are items in inventroy then update Inventory UI display
        foreach (Item item in PlayerInventory.Items)
        {

            GameObject itemUI = Instantiate(ItemHolderPrefab);
            itemUI.transform.SetParent(GridLayout, false);

            ItemUIController uiController = itemUI.GetComponent<ItemUIController>();
            uiController.ItemRef = item;


        }
    }

}
