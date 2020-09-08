using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trainskill : MonoBehaviour
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
          //  textbox.text = changeskill.options[index].text;
            string selection = items[index];
          //  textbox.text = selection;
            // changestuff = skilltextbox;
            if (selection == "Farming")
            {
                FarmingSkill.farmingtrain();
            }
            if (selection == "Blacksmithing")
            {
                BlackSmithingSkill.blacksmithtrain();
            }
        }

    }
    void Start()
    {
        var changeskill = transform.GetComponent<Dropdown>();

        changeskill.options.Clear();
        items.Add("");
        // List<string> items = new List<string>();
        items.Add("Farming");
        
            items.Add("Blacksmithing");

        foreach (var item in items)
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

