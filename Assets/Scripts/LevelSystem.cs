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
    void Start()
    { 
    var changeskill = transform.GetComponent<Dropdown>();
 
     changeskill.options.Clear();

    List<string> items = new List<string>();


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
     int index = changeskill.value;
    textbox.text = changeskill.options[index].text;
}
}
