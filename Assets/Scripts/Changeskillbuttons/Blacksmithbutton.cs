using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blacksmithbutton : MonoBehaviour
{
    public GameObject blacksmithbutton;
    public GameObject textbox;
    public static int cat;
    public static void island(int check)
    {
        cat = check;
    }
 
    public  void yes()
    {
        if (cat == 1)
        {
            textbox.GetComponent<Text>().text = "Blacksmithing";
            SetSkillsfalse.killthembuttens();
            BlackSmithingSkill.Setblacksmithactive();

        }
        if (cat == 2)
            {


            // BlackSmithingSkill.blacksmithtrain();
            SetSkillsfalse.killtrain();
            CurrentAction.setaction(cat);
            BlackSmithingSkill.blacksmithtrainactive = true;

        }
    }
}
