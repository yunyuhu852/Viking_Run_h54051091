using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{

    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Your Score :  " + static_var.timescore.ToString("0.00") + "  Seconds";
    }
}
