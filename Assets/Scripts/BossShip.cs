using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShip : MonoBehaviour
{
    [SerializeField] float speedAdjustment;
    public int shipCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speedAdjustment * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BoundaryBox")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            speedAdjustment *= -1;
        }
    }
}
