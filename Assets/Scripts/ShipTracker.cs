using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipTracker : MonoBehaviour
{
    [SerializeField] int shipCount;
    [SerializeField] TMP_Text shipText;
    [SerializeField] int sceneToLoad;
    [SerializeField] GameObject levelTwoPanel;
    private float victoryScreenTimer = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(shipCount <= 0)
        {
            levelTwoPanel.SetActive(true);
            victoryScreenTimer -= Time.deltaTime;
            if (victoryScreenTimer <= 0)
            {
                levelTwoPanel.SetActive(false);
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
    public void UpdateShips(int ships)
    {
        shipCount -= ships;
        shipText.text = "Enemies: " + shipCount;
    }
}
