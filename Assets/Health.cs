using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    private int totalHealth = 10;
    private GameObject panel;
    private bool isPaused = false;
    // Utte this for initialization
    void Start()
    {
        UpdateStarText();
        panel = GameObject.Find("PanelFailed");
        panel.SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Enemy"))
        {
            totalHealth = 0;
            UpdateStarText();
        }
    }

    private void UpdateStarText()
    {
        string status;

        if (totalHealth <= 0)
        {
            panel.SetActive(!panel.activeInHierarchy);
            /*if (isPaused)
                Time.timeScale = 1.0f;
            else
                Time.timeScale = 0.0f;
            isPaused = !isPaused;*/
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
