using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score_show : MonoBehaviour
{
    public Text score;

    // Update is called once per frame

    private void Start()
    {
        static_var.timescore = 0;
        static_var.collinsion_stone = 0;
    }
    void Update()
    {
        static_var.timescore += Time.deltaTime;
        score.text ="Time :  "+ static_var.timescore.ToString("0.00")+"  sec";
        if (static_var.collinsion_stone <= 0)
        {
            static_var.collinsion_stone = 0;
        }
        else
        {
            static_var.collinsion_stone -= Time.deltaTime;
        }
    }
}
