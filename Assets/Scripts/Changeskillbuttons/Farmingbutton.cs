using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Farmingbutton : MonoBehaviour
{
    public GameObject farmbutton;
    public GameObject textbox;


    public void yes(int check)
    {
        if (check == 1)
        {
            textbox.GetComponent<Text>().text = "Farming";
            SetSkillsfalse.killthembuttens();
            // SetSkillsfalse.noforrealnow();
            FarmingSkill.Setfarmingactive();
        }
        if (check == 2)
        {
            textbox.GetComponent<Text>().text = "Farming";
            SetSkillsfalse.killthembuttens();
            // SetSkillsfalse.noforrealnow();
            FarmingSkill.Setfarmingactive();
        }

    }

}
