using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour, IPointerClickHandler
{
    public GameObject canvasPrefab;
    public void OnPointerClick(PointerEventData eventData)
    {
        Instantiate(canvasPrefab, Vector2.zero, Quaternion.identity);
        Time.timeScale = 0f;
    }
}
