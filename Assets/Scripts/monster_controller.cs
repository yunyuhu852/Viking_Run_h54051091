using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_controller : MonoBehaviour
{

    public GameObject followed;
    private Quaternion quaternion;
    int dir = -1;

    // Update is called once per frame
    void Update()
    {
        float Position_X = followed.GetComponent<Transform>().position.x;
        float Position_Y = followed.GetComponent<Transform>().position.y;
        float Position_Z = followed.GetComponent<Transform>().position.z;
        float distance = static_var.collinsion_stone / 2;
        Vector3 Backward = followed.GetComponent<Transform>().forward * dir * (7 - distance);
        if (distance >= 7)
        {
            distance = 7;
        }
        transform.position = new Vector3(Position_X, Position_Y, Position_Z) + Backward;
        if (static_var.rotate == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), 0.05f);
        }
        if (static_var.rotate == 1)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), 0.05f);
        }
        if (static_var.rotate == 2)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 180, 0), 0.05f);
        }
        if (static_var.rotate == 3)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 270, 0), 0.05f);
        }
    }
}
