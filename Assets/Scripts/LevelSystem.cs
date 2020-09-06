using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

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
        index = changeskill.value;
        string selection = items[index];
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
        skilldropdown.SetActive(false);
    }
    void Start()
    { 
    var changeskill = transform.GetComponent<Dropdown>();
 
     changeskill.options.Clear();

   // List<string> items = new List<string>();


            skilllvl = BlackSmithingSkill.blacksmithlvl;
        if ( skilllvl >= 1)
        {
            items.Add("Blacksmithing");
        }
        skilllvl = FarmingSkill.farminglvl;
        if (skilllvl >= 1)
        {
             items.Add("Farming");
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
      index = changeskill.value;
    textbox.text = changeskill.options[index].text;
       changetheskill(changeskill);
        changeskill.onValueChanged.AddListener(delegate { changetheskill(changeskill); });
    }
}
