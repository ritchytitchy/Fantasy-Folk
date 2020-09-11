using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Farmingbutton : MonoBehaviour
{
    public GameObject farmbutton;
    public GameObject textbox;
    public static int cat;

    void Start()
    {
        textbox.GetComponent<Text>().text = "Farming";
    }

    public static void island(int check) 
        {
        cat = check;

        }

    public void magic()
    {
        
    }
    public  void yes()
    {
        textbox.GetComponent<Text>().text = "Farming";
        if (cat == 1)
        {
            SetSkillsfalse.killthembuttens();
            FarmingSkill.Setfarmingactive();
            
        }
        if (cat == 2)
        {
            SetSkillsfalse.killtrain();
            CurrentAction.setaction(cat);
            FarmingSkill.farmingtrainactive = true;
        }

    }

}
