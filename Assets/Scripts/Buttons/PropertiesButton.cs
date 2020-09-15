using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PropertiesButton : MonoBehaviour
{
    public GameObject actionButton;
    public GameObject propbutton;
    public GameObject StatsButton;
    public GameObject familyButton;
    public GameObject buyfarm;
    public GameObject sellfarm;
    public GameObject buyhouse;
    public GameObject sellhouse;
    public GameObject buyforge;
    public GameObject sellforge;
    public GameObject backButton;
    public GameObject skilltext;
    public GameObject housetext;
    public GameObject farmtext;
    public GameObject forgetext;
    public static int skeet = 2;


    //function when the button is clicked
    public void ClickpropButton()
    {
        Backbutton.getdunked(skeet);
        actionButton.SetActive(false);
        propbutton.SetActive(false);
        StatsButton.SetActive(false);
        familyButton.SetActive(false);
        skilltext.SetActive(false);
        buyfarm.SetActive(true);
        sellfarm.SetActive(true);
        buyhouse.SetActive(true);
        sellhouse.SetActive(true);
        buyforge.SetActive(true);
        sellforge.SetActive(true);
        backButton.SetActive(true);
        housetext.SetActive(true);
        farmtext.SetActive(true);
        forgetext.SetActive(true);
    }
    void Update()
    {

    }
}
