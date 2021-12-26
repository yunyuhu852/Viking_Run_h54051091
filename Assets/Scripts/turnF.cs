using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnF : MonoBehaviour
{
    [SerializeField] GameObject floor;
    [SerializeField] int dir = -1;
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "viking")
        {
            Spawn();
        }
    }
    public void Spawn()
    {
        Transform parent = transform.parent;
        Vector3 pos = parent.position + parent.right * dir * 14;
        Quaternion rot = Quaternion.LookRotation(parent.right * dir);
        Instantiate(floor, pos, rot);
        WaitAndDie();
    }
    public void WaitAndDie()
    {
        Destroy(transform.parent.gameObject, 6);
    }
}
