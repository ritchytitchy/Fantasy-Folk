using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    public static int num;
    public GameObject action;
    public static string xyz;
public void setaction()
    {

    }
   
    void Update()
    {
        action.GetComponent<Text>().text = "Current Action: " + xyz;
    }
}
