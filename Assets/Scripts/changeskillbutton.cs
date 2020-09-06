using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class changeskillbutton : MonoBehaviour
{
    public GameObject changeskilldropdown;
    public GameObject textbox;



    public void activatedropdown()
    {
        changeskilldropdown.SetActive(true);
        textbox.SetActive(true);
    }
}
