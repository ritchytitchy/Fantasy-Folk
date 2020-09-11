using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmingSkill : MonoBehaviour
{
    public static bool farmingactive = true;
    public static bool farmingtrainactive = false;
    public static int farminglvl = 1;
    public static int farmingxp = 0;
    public static int farmingxptolvl = 100;



        public static void Setfarmingactive()
        {
            farmingactive = true;
        }


    public static void farmingwork()
        {
            farmingxp += 10;
            if (farmingxp >= farmingxptolvl)
            {
                farminglvl += 1;
                farmingxp -= farmingxptolvl;
                farmingxptolvl += 100;
            }
            GlobalCurrencies.Gold += 5 * farminglvl;
        }
    public static void farmingtrain()
    {
        int tempg = GlobalCurrencies.Gold;
        if (tempg >= 10)
        {
            GlobalCurrencies.Gold -= 10;
            farmingxp += 10;
            if (farmingxp >= farmingxptolvl)
            {
                farminglvl += 1;
                farmingxp -= farmingxptolvl;
                farmingxptolvl += 100;
            }
        }

    }


}
