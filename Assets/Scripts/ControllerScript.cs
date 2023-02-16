using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    [SerializeField] float speedAdjustment = 4;
    [SerializeField] float hInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spent some time researching unity, im trying this input system for now, let me know if its good.
        //By default the controls on unity are set to the left and right arrow keys, or a and d.
        hInput = Input.GetAxisRaw("Horizontal");
        //This does all of the movement because getaxis makes hInput - alowing you to translate left which is kind of weird but it works.
        transform.Translate(Vector2.right * hInput * speedAdjustment * Time.deltaTime);
    }
}
