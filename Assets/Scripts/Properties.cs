using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

public class Properties : MonoBehaviour
{
   // public int rent;
    public static int hou = 0;
    public static int far = 0;
    public static int forg = 0;
    public static int coshou = 100;
    public static int cosfar = 50;
    public static int cosforg = 150;
    public GameObject numhou;
    public GameObject numfar;
    public GameObject numforg;
    public GameObject houpr;
    public GameObject farpr;
    public GameObject forpr;
    public static int fgold = GlobalCurrencies.Gold;
    public static int inrent()
    {
       int rent = (hou * 6) + (far * 3) + (forg * 10);
        return rent;

    }

    public static void buyhou()
    {
        if (fgold >= coshou)
        {
            GlobalCurrencies.Gold -= coshou;
            hou += 1;
        }
    }
    public static void sellhou()
    {   if (hou >= 1)
        {
            GlobalCurrencies.Gold += coshou;
            hou -= 1;
        }
    }
    public static void buyfar()
    {
        if (fgold >= cosfar)
        {
            GlobalCurrencies.Gold -= cosfar;
            far += 1;
        }
        
    }
    public static void sellfar()
    {
        if (far >= 1)
        {
        GlobalCurrencies.Gold += cosfar;
        far -= 1;
        }
    }
    public static void buyforg()
    {
        if (fgold >= cosforg)
        {
            GlobalCurrencies.Gold -= cosforg;
            forg += 1;
        }
        
    }
    public static void sellforg()
    {
        if (forg >= 1)
        {
        GlobalCurrencies.Gold += cosforg;
        forg -= 1;
        }
    }
    /*  public static void realproperty(int ty, int bos)
      {
          if (ty == 1)
          {
              if (bos == 1)
              {
                  hou += 1;
              }
              else
              {
                  hou -= 1;
              }
          }
          if (ty == 2)
          {
              if (bos == 1)
              {
                  far += 1;
              }
              else
              {
                  far -= 1;
              }
          }
          if (ty == 3)
          {
              if (bos == 1)
              {
                  forg += 1;
              }
              else
              {
                  forg -= 1;
              }
          }
      }*/

    // Update is called once per frame
    void Update()
    {
        numhou.GetComponent<Text>().text = "Houses: " + hou;
        numfar.GetComponent<Text>().text = "Farms: " + far;
        numforg.GetComponent<Text>().text = "Forges: " + forg;
        houpr.GetComponent<Text>().text = "Price: " + coshou;
        farpr.GetComponent<Text>().text = "Price: " + cosfar;
        forpr.GetComponent<Text>().text = "Price: " + cosforg;
    }
}
