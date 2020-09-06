using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkill : MonoBehaviour
{
    public GameObject skilldropdown;
   // string selection = LevelSystem.items[LevelSystem.index];
    


     public void  changetheskill()
    {
        string selection = LevelSystem.items[LevelSystem.index];
        // changestuff = skilltextbox;
        FarmingSkill.farmingactive = false;
        BlackSmithingSkill.blacksmithactive = false;
        if(selection == "Farming")
        {
            FarmingSkill.farmingactive = true;
        }
        if (selection == "Blacksmithing")
        {
            BlackSmithingSkill.blacksmithactive = true;
        }
        skilldropdown.SetActive(false);
    }

}
