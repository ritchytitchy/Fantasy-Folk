using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using UnityEngine;

public class CurrentSkill : MonoBehaviour
{
    public static bool activeskill;
    public void ClickWork()
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
}



