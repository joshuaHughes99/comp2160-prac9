using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //store whether the keys are being held down
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0) * moveSpeed; //calculate the direction of the movement
        movement *= Time.deltaTime; //scale the movement with time

        transform.Translate(movement); //move the player in the appropriate direction
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            //score++; //increase the score of the player, Commented out for the scorekeeper/User interface
            //Debug.Log(score);
        }
    }
}
