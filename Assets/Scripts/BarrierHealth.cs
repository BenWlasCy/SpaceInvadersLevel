using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierHealth : MonoBehaviour
{
    [SerializeField] int life = 3;
    [SerializeField] GameObject parentObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy Projectile" || collision.gameObject.tag == "Player Projectile")
        {
            Destroy(collision.gameObject);
            life -= 1;
            if (life == 2)
            {
                gameObject.GetComponentInParent<SpriteRenderer>().material.color = new Color(0f, 0f, 0.5f);
            }
            if (life == 1)
            {
                gameObject.GetComponentInParent<SpriteRenderer>().material.color = new Color(0f, 0f, 0.35f);
            }
            if (life <= 0)
            {
                Destroy(parentObject);
                Destroy(gameObject);
            }
        }
    }
}
