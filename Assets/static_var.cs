using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class static_var // 不能繼承MonoBehaviour，不能掛在物件上面
{
    public static float timescore;
    public static float collinsion_stone;
    public static int coinnumber;
    public static int rotate;

    static static_var()
    {    
        timescore = 0;
        collinsion_stone = 0;
        coinnumber = 0;
        rotate = 0;
    }
}
