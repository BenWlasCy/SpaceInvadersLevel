using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{
    [SerializeField] float projSpeed;
    private PointManager pointManager;
    private ShipTracker shipCounter;
    private BossBehaviour bossBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        shipCounter = GameObject.Find("ShipCounter").GetComponent<ShipTracker>();
        bossBehaviour = GameObject.Find("BossEnemy").GetComponent<BossBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * projSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            pointManager.UpdateScore(100);
            shipCounter.UpdateShips(1);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "BoundaryBox")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Barrier")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "BossEnemy")
        {
            pointManager.UpdateScore(25);
            bossBehaviour.UpdateHealth();
            Destroy(gameObject);
        }
    }
}
