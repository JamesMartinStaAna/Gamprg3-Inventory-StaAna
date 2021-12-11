using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemUIController : MonoBehaviour
{
    public Item ItemRef;
    public Image ItemDisplayIcon;
    public TextMeshProUGUI ItemQuantityText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (ItemRef == null)
        {
            //If object stack empty delete item UI
            Destroy(gameObject);
            ItemDisplayIcon.overrideSprite = null;
            ItemQuantityText.text = "";
        }
        else
        {
            ItemDisplayIcon.overrideSprite = ItemRef.Icon;
            if (ItemRef.ItemQuantity == 1)
            {
                ItemQuantityText.text = "";
            }
            else
            {
                ItemQuantityText.text = ItemRef.ItemQuantity.ToString();
            }
            
        }
       
     
    }

    public void OnClick()
    {
        if (ItemRef != null)
        {
            ItemRef.Use();
        }
    }

    void OnDisable()
    {
        Destroy(gameObject);
    }
}
