﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class changeskillbutton : MonoBehaviour
{
    public GameObject textbox;
    public GameObject farmingbutton;
    public GameObject blacksmithbutton;
    public static int skilllvl;
    public static int check = 1;





    public void activatedropdown()
    {
        
        textbox.SetActive(true);
        skilllvl = FarmingSkill.farminglvl;
        if (skilllvl >= 1)
        {
            farmingbutton.SetActive(true);
           // Farmingbutton.yes(check);
        }
        skilllvl = BlackSmithingSkill.blacksmithlvl;
        if (skilllvl >= 1)
        {
            blacksmithbutton.SetActive(true);
            //Blacksmithbutton.yes(check);
        }


    }
}
