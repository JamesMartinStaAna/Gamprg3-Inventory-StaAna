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
            ItemDisplayIcon.overrideSprite = null;
            ItemQuantityText.text = "";
        }
        else
        {
            ItemDisplayIcon.overrideSprite = ItemRef.Icon;
            ItemQuantityText.text = ItemRef.ItemQuantity.ToString();
        }
    }

    public void OnClick()
    {
        if (ItemRef != null)
        {
            ItemRef.Use();
        }
    }
}
