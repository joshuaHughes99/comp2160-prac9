using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float lifeSpan;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lifeSpan -= Time.deltaTime;

        if (lifeSpan <= 0) //The coin only lasts as long as the designer chooses
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player") //if the coin collides with an object with the "player" tag
        {
            Destroy(gameObject);
        }
    }
}
