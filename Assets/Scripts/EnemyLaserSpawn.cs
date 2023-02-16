using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserSpawn : MonoBehaviour
{

    [SerializeField] GameObject enemyLaser;
    [SerializeField] float randomTimer;
    [SerializeField] float maxTime = 20;
    [SerializeField] float minTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        randomTimer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        randomTimer -= Time.deltaTime;
        if (randomTimer <= 0)
        {
            Instantiate(enemyLaser, transform.position, Quaternion.identity);
            randomTimer = Random.Range(minTime, maxTime);
        }
    }
}
