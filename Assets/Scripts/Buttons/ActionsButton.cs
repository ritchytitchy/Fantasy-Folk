using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsButton : MonoBehaviour
{
    public GameObject actionButton;
    public GameObject PropertiesButton;
    public GameObject StatsButton;
    public GameObject WorkButton;
    public GameObject changeskillButton;
    public GameObject trainButton;
    public GameObject familyButton;
    public GameObject backButton;
    public static int skeeter = 1;

    //function when the button is clicked
    public void ClickActionButton()
        {
        Backbutton.getdunked(skeeter);
        actionButton.SetActive(false);
            PropertiesButton.SetActive(false);
            StatsButton.SetActive(false);
            familyButton.SetActive(false);
            WorkButton.SetActive(true);
            changeskillButton.SetActive(true);
            trainButton.SetActive(true);
            backButton.SetActive(true);
    }

}
