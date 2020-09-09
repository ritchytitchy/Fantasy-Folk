using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainbutton : MonoBehaviour
{
    public GameObject textbox;
    public GameObject farmingbutton;
    public GameObject blacksmithbutton;
    //public static int skilllvl;
    public static int check = 2;





    public void activatedropdown()
    {

        textbox.SetActive(true);
        {
            farmingbutton.SetActive(true);
        }

        {
            blacksmithbutton.SetActive(true);
        }


    }
}
