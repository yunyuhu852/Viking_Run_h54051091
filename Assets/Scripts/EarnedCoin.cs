using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnedCoin : MonoBehaviour
{
    public Text coin;

    // Start is called before the first frame update
    void Start()
    {
        coin.text = "You get :  " + static_var.coinnumber.ToString()+"  Coins";
    }
}
