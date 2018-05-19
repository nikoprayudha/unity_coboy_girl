using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Audio;

public class Player : MonoBehaviour {

    public Text starText;
    private int totalStars = 0;
    private GameObject panel;
    private bool isPaused = false;
    // Use this for initialization
    void Start () {
        UpdateStarText();
        panel = GameObject.Find("PanelComplete");
        panel.SetActive(false);
	}

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Star"))
        {
            totalStars++;
            UpdateStarText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateStarText()
    {
        string starMessage = "Coins = " + totalStars;
        starText.text = starMessage;

        //string starMessage;
        string missionmessage;

        if (totalStars == 37)
        {
            missionmessage = "" + totalStars;
            //missionComplete.text = missionmessage;
            panel.SetActive(!panel.activeInHierarchy);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
