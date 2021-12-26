using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScoreShow : MonoBehaviour
{

    public Text coin;

    void Update()
    { 
        coin.text = "Get :  " + static_var.coinnumber.ToString() + "  coins";
    }
}
