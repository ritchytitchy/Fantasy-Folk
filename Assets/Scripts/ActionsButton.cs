using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsButton : MonoBehaviour
{
    public GameObject actionButton;
    public GameObject PropertiesButton;
    public GameObject StatsButton;
    public GameObject WorkButton;

        //function when the button is clicked
        public void ClickActionButton()
        {
            actionButton.SetActive(false);
            PropertiesButton.SetActive(false);
            StatsButton.SetActive(false);
            WorkButton.SetActive(true);
        }

}
