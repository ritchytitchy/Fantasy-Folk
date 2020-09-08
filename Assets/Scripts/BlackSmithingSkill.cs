using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class BlackSmithingSkill : MonoBehaviour
{

    public static bool blacksmithactive = false;
    public static int blacksmithlvl = 0;
    public static int blacksmithxp = 0;
    public static int blacksmithxptolvl = 30;



        public void Setblacksmithactive()
        {
            blacksmithactive = true;
        }

        public static void blacksmithwork()
        {
            blacksmithxp += 10;
            if (blacksmithxp >= blacksmithxptolvl)
            {
                blacksmithlvl += 1;
                blacksmithxp -= blacksmithxptolvl;
                blacksmithxptolvl += 100;
            }
            GlobalCurrencies.Gold += 10 * blacksmithlvl;
        }
    public static void blacksmithtrain()
    {
        blacksmithxp += 10;
        if (blacksmithxp >= blacksmithxptolvl)
        {
            blacksmithlvl += 1;
            blacksmithxp -= blacksmithxptolvl;
            blacksmithxptolvl += 100;
        }

    }

}
