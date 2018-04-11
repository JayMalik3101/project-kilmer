using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour {

    public GameObject gameOverPanel;

    public Text gameOverText;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = Player.gameObject.name + " wins!";
        }
    }
}
