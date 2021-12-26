using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class create_map : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] GameObject coner;
    [SerializeField] GameObject stone;
    [SerializeField] GameObject coins;
    [SerializeField] GameObject coinsR;
    [SerializeField] GameObject coinsUL;
    [SerializeField] GameObject coinsUR;

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "viking")
        {
            Copy();
        }
    }
    public void Copy()
    {
        int chance = Random.Range(1, 11);
        int coin_chance = Random.Range(0, 16);
        float length;
        #region 空格
        if (chance > 6)
        {
             length = 41.5f;
        }
        else
        {
             length = 35.9f;
        }
        #endregion
        Vector3 pos = transform.parent.position + transform.forward*length;
        Vector3 coner_pos = transform.parent.position + transform.forward * 33.9f;
        Vector3 stone_pos;
        Vector3 coin_pos = transform.parent.position + new Vector3(coins.GetComponent<Transform>().position.x, coins.GetComponent<Transform>().position.y, coins.GetComponent<Transform>().position.z) + transform.forward * Random.Range(1f, 30f);
        Vector3 coin_posDR = transform.parent.position + new Vector3(coinsR.GetComponent<Transform>().position.x, coinsR.GetComponent<Transform>().position.y, coins.GetComponent<Transform>().position.z) + transform.forward * Random.Range(1f, 30f);
        Vector3 coin_posUL = transform.parent.position + new Vector3(coinsUL.GetComponent<Transform>().position.x, coinsUL.GetComponent<Transform>().position.y, coinsUL.GetComponent<Transform>().position.z) + transform.forward * Random.Range(1f, 30f);
        Vector3 coin_posUR = transform.parent.position + new Vector3(coinsUR.GetComponent<Transform>().position.x, coinsUR.GetComponent<Transform>().position.y, coinsUR.GetComponent<Transform>().position.z) + transform.forward * Random.Range(1f, 30f);
        #region map生成
        if (Random.value <= 0.4)
        {
            Instantiate(coner, coner_pos, transform.rotation);
            WaitAndDie();
        }
        else
        {
            Instantiate(map, pos, transform.rotation);
            WaitAndDie();
        }
        #endregion
        #region stone 生成
        if (Random.value <= 0.5)
        {
            if (chance > 6)
            {
                stone_pos = transform.position + transform.forward * Random.Range(8f, 20f);
            }
            else
            {
                stone_pos = transform.position + transform.forward* Random.Range(8f, 10f);
            }
           GameObject stone_clone =  Instantiate(stone, stone_pos, Quaternion.LookRotation(transform.forward));
            if (chance < 4)
            {
                GameObject clone1 = Instantiate(stone, stone_pos+ transform.forward *10f, Quaternion.LookRotation(transform.forward));
                if (static_var.timescore >= 60)
                {
                    Destroy(clone1, 2);
                }
                else
                {
                    Destroy(clone1, 4);
                }
            }
            if (static_var.timescore >= 60)
            {
                Destroy(stone_clone, 2);
            }
            else
            {
                Destroy(stone_clone, 4);
            }
        }
        #endregion
        #region coins生成
        switch (coin_chance)
        {
            case 0:
                break;

            case 1:
                GameObject coin_cloneDL = Instantiate(coins, coin_pos, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDL, 4f);
                break;

            case 2:
                GameObject coin_cloneDR = Instantiate(coinsR, coin_posDR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDR, 4f);
                break;

            case 3:
                coin_cloneDL = Instantiate(coins, coin_pos, Quaternion.LookRotation(transform.forward));
                coin_cloneDR = Instantiate(coinsR, coin_posDR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDL, 4f);
                Destroy(coin_cloneDR, 4f);
                break;

            case 4:
                GameObject coin_cloneUL = Instantiate(coinsUL, coin_posUL, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneUL, 4f);
                break;

            case 5:
                coin_cloneDL = Instantiate(coins, coin_pos, Quaternion.LookRotation(transform.forward));
                coin_cloneUL = Instantiate(coinsUL, coin_posUL, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDL, 4f);
                Destroy(coin_cloneUL, 4f);
                break;

            case 6:
                coin_cloneDR = Instantiate(coinsR, coin_posDR, Quaternion.LookRotation(transform.forward));
                coin_cloneUL = Instantiate(coinsUL, coin_posUL, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDR, 4f);
                Destroy(coin_cloneUL, 4f);
                break;

            case 7:
                coin_cloneDL = Instantiate(coins, coin_pos, Quaternion.LookRotation(transform.forward));
                coin_cloneDR = Instantiate(coinsR, coin_posDR, Quaternion.LookRotation(transform.forward));
                coin_cloneUL = Instantiate(coinsUL, coin_posUL, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDL, 4f);
                Destroy(coin_cloneDR, 4f);
                Destroy(coin_cloneUL, 4f);
                break;

            case 8:
                GameObject coin_cloneUR = Instantiate(coinsUR, coin_posUR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneUR, 4f);
                break;

            case 9:
                coin_cloneDL = Instantiate(coins, coin_pos, Quaternion.LookRotation(transform.forward));
                coin_cloneUR = Instantiate(coinsUR, coin_posUR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDL, 4f);
                Destroy(coin_cloneUR, 4f);
                break;

            case 10:
                coin_cloneDR = Instantiate(coinsR, coin_posDR, Quaternion.LookRotation(transform.forward));
                coin_cloneUR = Instantiate(coinsUR, coin_posUR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDR, 4f);
                Destroy(coin_cloneUR, 4f);
                break;

            case 11:
                coin_cloneDL = Instantiate(coins, coin_pos, Quaternion.LookRotation(transform.forward));
                coin_cloneDR = Instantiate(coinsR, coin_posDR, Quaternion.LookRotation(transform.forward));
                coin_cloneUR = Instantiate(coinsUR, coin_posUR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDL, 4f);
                Destroy(coin_cloneDR, 4f);
                Destroy(coin_cloneUR, 4f);
                break;

            case 12:
                coin_cloneUL = Instantiate(coinsUL, coin_posUL, Quaternion.LookRotation(transform.forward));
                coin_cloneUR = Instantiate(coinsUR, coin_posUR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneUL, 4f);
                Destroy(coin_cloneUR, 4f);
                break;

            case 13:
                coin_cloneDL = Instantiate(coins, coin_pos, Quaternion.LookRotation(transform.forward));
                coin_cloneUL = Instantiate(coinsUL, coin_posUL, Quaternion.LookRotation(transform.forward));
                coin_cloneUR = Instantiate(coinsUR, coin_posUR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDL, 4f);
                Destroy(coin_cloneUL, 4f);
                Destroy(coin_cloneUR, 4f);
                break;

            case 14:
                coin_cloneDR = Instantiate(coinsR, coin_posDR, Quaternion.LookRotation(transform.forward));
                coin_cloneUL = Instantiate(coinsUL, coin_posUL, Quaternion.LookRotation(transform.forward));
                coin_cloneUR = Instantiate(coinsUR, coin_posUR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDR, 4f);
                Destroy(coin_cloneUL, 4f);
                Destroy(coin_cloneUR, 4f);
                break;

            case 15:
                coin_cloneDL = Instantiate(coins, coin_pos, Quaternion.LookRotation(transform.forward));
                coin_cloneDR = Instantiate(coinsR, coin_posDR, Quaternion.LookRotation(transform.forward));
                coin_cloneUL = Instantiate(coinsUL, coin_posUL, Quaternion.LookRotation(transform.forward));
                coin_cloneUR = Instantiate(coinsUR, coin_posUR, Quaternion.LookRotation(transform.forward));
                Destroy(coin_cloneDL, 4f);
                Destroy(coin_cloneDR, 4f);
                Destroy(coin_cloneUL, 4f);
                Destroy(coin_cloneUR, 4f);
                break;

            default:
                break;
        }
        #endregion

    }
    public void WaitAndDie()
    {
        if (static_var.timescore >= 60)
        {
            Destroy(transform.parent.gameObject, 3f);
        }
        else if(static_var.timescore >= 40)
        {
            Destroy(transform.parent.gameObject, 3f);
        }
        else
        {
            Destroy(transform.parent.gameObject, 5f);
        }
    }
}

