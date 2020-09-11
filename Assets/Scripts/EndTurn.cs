using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    public static bool activeskill;
    public static int actionz;
    public static void grabaction(int fun)
    {
        actionz = fun;
    }
    public void Clickend()
    {
        if (actionz == 1)
        {

            activeskill = BlackSmithingSkill.blacksmithactive;
            if (activeskill == true)
            {
                BlackSmithingSkill.blacksmithwork();
            }
            activeskill = FarmingSkill.farmingactive;
            if (activeskill == true)
            {
                FarmingSkill.farmingwork();
            }
        }
        if (actionz == 2)
        {

            activeskill = BlackSmithingSkill.blacksmithtrainactive;
            if (activeskill == true)
            {
                BlackSmithingSkill.blacksmithtrain();
            }
            activeskill = FarmingSkill.farmingtrainactive;
            if (activeskill == true)
            {
                FarmingSkill.farmingtrain();
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
