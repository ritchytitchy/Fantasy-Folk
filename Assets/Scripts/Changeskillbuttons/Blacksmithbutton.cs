using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blacksmithbutton : MonoBehaviour
{
    public GameObject blacksmithbutton;
    public GameObject textbox;


    public  void yes(int check)
    {
        if (check == 1)
        {
            textbox.GetComponent<Text>().text = "Blacksmithing";
            SetSkillsfalse.killthembuttens();
            // SetSkillsfalse.noforrealnow();
            BlackSmithingSkill.Setblacksmithactive();

        }
        if (check == 2)
            {
            textbox.GetComponent<Text>().text = "Blacksmithing";
            SetSkillsfalse.killthembuttens();
            // SetSkillsfalse.noforrealnow();
            BlackSmithingSkill.Setblacksmithactive();

        }
    }
}
