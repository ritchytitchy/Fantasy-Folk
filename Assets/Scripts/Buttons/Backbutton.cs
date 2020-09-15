using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Backbutton : MonoBehaviour
{
    public static int pass;
    public GameObject actionButton;
    public GameObject PropertiesButton;
    public GameObject StatsButton;
    public GameObject WorkButton;
    public GameObject changeskillButton;
    public GameObject trainButton;
    public GameObject familyButton;
    public GameObject backButton;
    public GameObject buyfarm;
    public GameObject sellfarm;
    public GameObject buyhouse;
    public GameObject sellhouse;
    public GameObject buyforge;
    public GameObject sellforge;
    public GameObject skilltext;
    public GameObject housetext;
    public GameObject farmtext;
    public GameObject forgetext;

    public static void getdunked(int thepass)
    {
        pass = thepass;
    }

    //function when the button is clicked
    public void ClickActionButton()
    {
    if (pass == 1)
    { 
        actionButton.SetActive(true);
        PropertiesButton.SetActive(true);
        StatsButton.SetActive(true);
        familyButton.SetActive(true);
        WorkButton.SetActive(false);
        changeskillButton.SetActive(false);
        trainButton.SetActive(false);
        backButton.SetActive(false);
    }
    if (pass == 2)
    {
        actionButton.SetActive(true);
        PropertiesButton.SetActive(true);
        StatsButton.SetActive(true);
        familyButton.SetActive(true);
        skilltext.SetActive(true);
        buyfarm.SetActive(false);
        sellfarm.SetActive(false);
        buyhouse.SetActive(false);
        sellhouse.SetActive(false);
        buyforge.SetActive(false);
        sellforge.SetActive(false);
        backButton.SetActive(false);
            housetext.SetActive(false);
            farmtext.SetActive(false);
            forgetext.SetActive(false);
        }

}
}
