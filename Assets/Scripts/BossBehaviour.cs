using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    [SerializeField] int healthPoints;
    private ShipTracker shipCounter;
    // Start is called before the first frame update
    void Start()
    {
        shipCounter = GameObject.Find("ShipCounter").GetComponent<ShipTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHealth()
    {
        healthPoints--;
        if (healthPoints <=4)
        {
            gameObject.GetComponent<SpriteRenderer>().material.color = new Color(0.8f, 0.8f, 0.5f);
        }
        if (healthPoints <= 0)
        {
            shipCounter.UpdateShips(1);
            Destroy(gameObject);
        }
    }
}
