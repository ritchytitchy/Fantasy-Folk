using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using UnityEngine;

public class CurrentSkill : MonoBehaviour
{
    public static int work = 1;
    public  void mwork()
    {
        CurrentAction.setaction(work);
    }
}



