﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkillsfalse : MonoBehaviour
{
    public  GameObject farmbuttonz;
    public  GameObject blacksmithbuttonz;


    public static void killthembuttens()
    {
        BlackSmithingSkill.blacksmithactive = false;
        FarmingSkill.farmingactive = false;   
    }
    public static void killtrain()
    {
        BlackSmithingSkill.blacksmithtrainactive = false;
        FarmingSkill.farmingtrainactive = false;
    }

    public void noforrealnow()
    {
        blacksmithbuttonz.SetActive(false);
        farmbuttonz.SetActive(false);
    }

}
