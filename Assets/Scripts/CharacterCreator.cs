using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour
{
    public GameObject VitalityDisplay;
    public static int Vitality = 1;
    public GameObject IntellectDisplay;
    public static int Intellect = 2;
    public GameObject CharismaDisplay;
    public static int Charisma = 3;
    public GameObject AgeDisplay;
    public static int Age = 16;

    // Update is called once per frame
    void Update()
    {
        VitalityDisplay.GetComponent<Text>().text = "Vitality: " + Vitality;
        IntellectDisplay.GetComponent<Text>().text = "Intellect: " + Intellect;
        CharismaDisplay.GetComponent<Text>().text = "Charisma: " + Charisma;
        AgeDisplay.GetComponent<Text>().text = "Age: " + Age;
    }
}
