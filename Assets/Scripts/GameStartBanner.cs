using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartBanner : MonoBehaviour
{

    [SerializeField] GameObject levelPanel;
    [SerializeField] float timeToStartGame;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeToStartGame -= Time.fixedDeltaTime;
        if (timeToStartGame <= 0)
        {
            StartGame();
            timeToStartGame = 0;
        }
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        levelPanel.SetActive(false);
    }
}
