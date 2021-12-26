using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_stra : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        if (other.name == "viking")
        {
            static_var.collinsion_stone += 0.2f;
        }
    }
}
