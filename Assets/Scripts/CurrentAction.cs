using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentAction : MonoBehaviour
{
    public static int num;
    public GameObject action;
    public static void setaction(int wow)
    {
        num = wow;
    }

    void Update()
    {
        EndTurn.grabaction(num);
        if (num == 1) 
        { 
        action.GetComponent<Text>().text = "Current Action: Work";
            
        }
        if (num == 2)
        {
            action.GetComponent<Text>().text = "Current Action: Train";
            
        }

    }
}
