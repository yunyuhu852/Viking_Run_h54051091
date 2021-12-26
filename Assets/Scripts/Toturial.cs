using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Toturial : MonoBehaviour, IPointerClickHandler
{
    int SceneIndexDestination = 3;
    public void OnPointerClick(PointerEventData eventData)
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("current scene name = " + scene.name + "and scene index = " + scene.buildIndex);


        SceneManager.LoadScene(SceneIndexDestination);
    }
}
