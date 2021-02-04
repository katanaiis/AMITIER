using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListManager : MonoBehaviour
{
    [System.Serializable]
    public struct ListObject
    {
        public string id;
        public List<Sprite> sprites;
    }


    /*public Transform ContentA;
    public Transform ContentB;
    public Transform ContentC;
    public Transform ContentD;
    public Transform ContentE;
    public Transform ContentF;
    public Transform ContentG;
    public Transform ContentH;
    public Transform ContentJ;
    public Transform ContentK;
    public Transform ContentL;
    public Transform ContentM;*/


    /* How to use
    * Create a list of List objects in any order with an id (ex : Animals)
    * Add all sprites of this type
    *
    * Then put all id you want with order you want in the ListOrder
    *
    * btnPrefab is used to create a button who will affect the all List
    * imgPrefab is used to create the end image of the to
    *
    * ContentObjects is the content where all btnPrefab will be placed, it is refresh automatically
    * ContentAll is the content where clicked button will go
    */
    [Header("List Organization")]
    public List<ListObject> ObjectsList = new List<ListObject>();
    public List<string> ListOrder = new List<string>();

    [Header("Prebas")]
    public GameObject btnPrefab;
    public GameObject imgPrefab;

    [Header("Contents")]
    public Transform ContentObjects;
    public Transform ContentAll;

    private int IndexList = 0;

    //public static bool disabled = false;

    private void Start()
    {
        RefreshContent();
    }

    /* Useless in this version
    * But Not deleted if needs
    public void ListCreator()
    {
        #region  ----- Anais Part ------

        int a = 2;   // genre
        int b = 12;  //astrologie
        int c = 7;  //meteo
        int d = 12; //colors
        int e = 12; //emotions 
        int f = 6; //fruits
        int g = 18; //animaux
        int h = 4; //saisons
        int j = 6; //continents
        int k = 12; //loisirs
        int l = 6; //sports
        int m = 12; //vocations

        //Random.Range(2, 6) (random)

        for (int i = 0; i < a; i++)
        {
            Transform newA = Instantiate(btnPrefab, ContentA).transform;
            newA.GetComponent<ImageManager>().Set(this, "A_" + i);
        }
        for (int i = 0; i < b; i++)
        {
            Transform newB = Instantiate(btnPrefab, ContentB).transform;
            newB.GetComponent<ImageManager>().Set(this, "B_" + i);
        }
        for (int i = 0; i < c; i++)
        {
            Transform newC = Instantiate(btnPrefab, ContentC).transform;
            newC.GetComponent<ImageManager>().Set(this, "C_" + i);
        }
        for (int i = 0; i < d; i++)
        {
            Transform newD = Instantiate(btnPrefab, ContentD).transform;
            newD.GetComponent<ImageManager>().Set(this, "D_" + i);
        }
        for (int i = 0; i < e; i++)
        {
            Transform newE = Instantiate(btnPrefab, ContentE).transform;
            newE.GetComponent<ImageManager>().Set(this, "E_" + i);
        }
        for (int i = 0; i < f; i++)
        {
            Transform newF = Instantiate(btnPrefab, ContentF).transform;
            newF.GetComponent<ImageManager>().Set(this, "F_" + i);
        }
        for (int i = 0; i < g; i++)
        {
            Transform newG = Instantiate(btnPrefab, ContentG).transform;
            newG.GetComponent<ImageManager>().Set(this, "G_" + i);
        }
        for (int i = 0; i < h; i++)
        {
            Transform newH = Instantiate(btnPrefab, ContentH).transform;
            newH.GetComponent<ImageManager>().Set(this, "H_" + i);
        }
        for (int i = 0; i < j; i++)
        {
            Transform newJ = Instantiate(btnPrefab, ContentJ).transform;
            newJ.GetComponent<ImageManager>().Set(this, "J_" + i);
        }
        for (int i = 0; i < k; i++)
        {
            Transform newK = Instantiate(btnPrefab, ContentK).transform;
            newK.GetComponent<ImageManager>().Set(this, "K_" + i);
        }
        for (int i = 0; i < l; i++)
        {
            Transform newL = Instantiate(btnPrefab, ContentL).transform;
            newL.GetComponent<ImageManager>().Set(this, "L_" + i);
        }
        for (int i = 0; i < m; i++)
        {
            Transform newM = Instantiate(btnPrefab, ContentM).transform;
            newM.GetComponent<ImageManager>().Set(this, "M_" + i);
        }

        #endregion
        
    }
    */

    /* Save Item in the AllList
     */
    public void Save(ImageManager imageMan)
    {
        Transform newAll = Instantiate(imgPrefab, ContentAll).transform;
        newAll.GetComponent<ImageManager>().Set(this, imageMan.image);

        RefreshContent();
    }

    /* Refresh ContentObjects
    */
    void RefreshContent()
    {
        /* Delete all childs objects
         */
        foreach (Transform child in ContentObjects)
        {
            Destroy(child.gameObject);
        }

        /* Replace childs objects by new list of sprites
         */
        if(IndexList < ListOrder.Count)
        {
            foreach (Sprite sprite in GetList(ListOrder[IndexList]))
            {
                Transform newObj = Instantiate(btnPrefab, ContentObjects).transform;
                newObj.GetComponent<ImageManager>().Set(this, sprite);
            }

            IndexList++;
        }
        else 
        {
            Debug.Log("Fin de la liste");
            ContentObjects.gameObject.SetActive(false);
            ContentAll.gameObject.SetActive(true);
            //ContentObjects.SetActive(false);
            //ContentAll.SetActive(true);

        }

    }

    /* Return list of sprites with id
    */
    List<Sprite> GetList(string id)
    {
        foreach (ListObject item in ObjectsList)
        {
            if(item.id == id)
            {
                return item.sprites;
            }
        }

        return new List<Sprite>();
    }
}
