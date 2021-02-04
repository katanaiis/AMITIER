using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonQuit : MonoBehaviour
{
    //public Canvas canvas;

    //layer0-1
    public Transform Layer0; //listA > listM
    public Transform Layer1; //listAll

    //listA .... listM 
    public Transform ListA; //genre
    public Transform ListB; //astro
    public Transform ListC; //météo
    public Transform ListD; //colors
    public Transform ListE; //emotions
    public Transform ListF; //fruits
    public Transform ListG; //animaux
    public Transform ListH; //saisons
    public Transform ListJ; //continents
    public Transform ListK; //loisirs
    public Transform ListL; //sports
    public Transform ListM; //vocations

    //faire une liste de liste??? 

    public void Quit() //onclick
    {
        //liste actuelle.disabled;
        //liste suivante.enabled;


        //if(dernière liste.disabled) 
        //ou
        //if(Toutes les liste.disabled) // une fois que toute les liste du layer0 sont désactivées > alors c'est le layer1 et sa liste qu'on active
        {
            //Layer0.disabled;

            //Layer1.enabled; 
            //listAll.enabled
        }
    }
}
