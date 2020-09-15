using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    public static int week = 1;
    public static int month;
    public GameObject date;
    public static string xyz;
    public static string[] yep = new string[] { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
    public static void thedate()
    {
        if (week < 5)
        {
            week += 1;
        }
        if (week == 5)
        {
           int darent = Properties.inrent();
            int lifex = Lifestyle.life();
           GlobalCurrencies.Gold += darent;
           GlobalCurrencies.Gold -= lifex;
            if (month <= 11)
            {
                week = 1;
                month += 1;
              //  Lifestyle.life();
            }
            if (month == 12)
            {
                week = 1;
                month = 0;
               // Lifestyle.life();
            }
        }
    }
   
    void Update()
    {
        date.GetComponent<Text>().text = "Date: Week " + week + " " +yep[month];
    }
}
