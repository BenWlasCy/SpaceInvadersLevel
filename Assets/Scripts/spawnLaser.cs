using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLaser : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // For me spawn Fire1 is set to space, I don't know if downloading my project will set the setting to space or not when you download it for grading.
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }
    }
}
