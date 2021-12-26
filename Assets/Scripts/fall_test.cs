using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fall_test : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        turn();
    }
    public void turn()
    {
        int SceneIndexDestination = 2;
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("current scene name = " + scene.name + "and scene index = " + scene.buildIndex);


        SceneManager.LoadScene(SceneIndexDestination);
    }
}
