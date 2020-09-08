using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelSystem : MonoBehaviour
{
    public Text textbox;
    public static int skilllvl;
    public static List<string> items = new List<string>();
    public static int index;
    public GameObject skilldropdown;
    // string selection = LevelSystem.items[LevelSystem.index];



    void changetheskill(Dropdown changeskill)
    {
        if (changeskill.value != 0)
        {
            
            index = changeskill.value;
           // textbox.text = changeskill.options[index].text;
            string selection = items[index];
            textbox.text = selection;
            // changestuff = skilltextbox;
            FarmingSkill.farmingactive = false;
            BlackSmithingSkill.blacksmithactive = false;
            if (selection == "Farming")
            {
                FarmingSkill.farmingactive = true;
            }
            if (selection == "Blacksmithing")
            {
                BlackSmithingSkill.blacksmithactive = true;
            }
        }
        
        

    }
    void Start()
    { 
    var changeskill = transform.GetComponent<Dropdown>();
 
     changeskill.options.Clear();

        // List<string> items = new List<string>();


        items.Add("");    
        skilllvl = FarmingSkill.farminglvl;
        if (skilllvl >= 1)
        {
            items.Add("Farming");
        }
        skilllvl = BlackSmithingSkill.blacksmithlvl;
        if ( skilllvl >= 1)
        {
            items.Add("Blacksmithing");
        }

        foreach(var item in items)
        {
         changeskill.options.Add(new Dropdown.OptionData() { text = item });
        }
 
    DropdownItemSelected(changeskill);

        changeskill.onValueChanged.AddListener(delegate { DropdownItemSelected(changeskill); });




    }
        void DropdownItemSelected(Dropdown changeskill)
    {
        skilldropdown.SetActive(false);
        index = changeskill.value;
    
       changetheskill(changeskill);
        changeskill.value = 0;
    }

}
