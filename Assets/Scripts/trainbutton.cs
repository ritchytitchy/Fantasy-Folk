using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainbutton : MonoBehaviour
{
    public GameObject changeskilldropdown;
    public GameObject textbox;



    public void activatedropdown()
    {
        changeskilldropdown.SetActive(true);
        textbox.SetActive(true);

    }
}
