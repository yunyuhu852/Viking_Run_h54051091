using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour , IPointerClickHandler
{

    public int SceneIndexDestination = 1;
    public void OnPointerClick(PointerEventData eventData)
    {
        Time.timeScale = 1f;
        static_var.coinnumber = 0;
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("current scene name = " + scene.name + "and scene index = " + scene.buildIndex);


        SceneManager.LoadScene(SceneIndexDestination);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
