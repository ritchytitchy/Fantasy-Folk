using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backbutton : MonoBehaviour
{
    public GameObject actionButton;
    public GameObject PropertiesButton;
    public GameObject StatsButton;
    public GameObject WorkButton;
    public GameObject changeskillButton;
    public GameObject trainButton;
    public GameObject familyButton;
    public GameObject backButton;

    //function when the button is clicked
    public void ClickActionButton()
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
}
