using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCurrencies : MonoBehaviour
{
    public GameObject HonourDisplay;
    public static int Honour = 0;
    public GameObject GoldDisplay;
    public static int Gold = 0;

    // Update is called once per frame
    void Update()
    {
        HonourDisplay.GetComponent<Text>().text = "Honour: " + Honour;
        GoldDisplay.GetComponent<Text>().text = "Gold: " + Gold;

    }
}
