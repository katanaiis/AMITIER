using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    public Sprite image;

    public ListManager listManager;
    
    public Transform ChildToChange;

    /* Set variables needs
     */
    public void Set(ListManager listManager, Sprite image)
    {
        this.image = image;
        this.listManager = listManager;
        ChildToChange.GetComponent<Image>().sprite = image;
    }

    /* Save to the main list
     */
    public void SaveToManager()
    {
        if (!listManager)
            Debug.LogError("Error - No listManager created or linked to this object.");
        listManager.Save(this);
    }
}
