using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCoin : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "viking")
        {
            Make();
        }
    }
    public void Make()
    {
        static_var.coinnumber++;
        Destroy(gameObject);
    }
}
