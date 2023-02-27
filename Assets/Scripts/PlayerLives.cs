using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{

    [SerializeField] int lives = 3;
    [SerializeField] Image[] livesUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When ship collides with player, deal one life and destroy ship
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            lives -= 1;
            for(int index = 0; index < livesUI.Length; index++)
            {
                if(index < lives)
                {
                    livesUI[index].enabled = true;
                }
                else
                {
                    livesUI[index].enabled = false;
                }
            }
            if(lives <= 0 )
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy Projectile")
        {
            Destroy(collision.gameObject);
            lives -= 1;
            for (int index = 0; index < livesUI.Length; index++)
            {
                if (index < lives)
                {
                    livesUI[index].enabled = true;
                }
                else
                {
                    livesUI[index].enabled = false;
                }
            }
            if (lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
