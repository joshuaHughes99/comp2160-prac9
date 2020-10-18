using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public Coin coinPrefab;
    private Vector3 world;
    private Vector3 spawnLocation;
    public float spawnCoinTimer = 3;
    public float spawnTimer = 5;


    // Start is called before the first frame update
    void Start()
    {
        world = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        spawnLocation = new Vector3(Random.Range(-world.x, world.x), Random.Range(-world.y, world.y), 0); //Spawn the coin at a random place within the screens width and height
        spawnTimer = spawnCoinTimer;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0)
        {
            Coin coin = Instantiate(coinPrefab, spawnLocation, Quaternion.identity); //spawn the coin at the location
            spawnTimer = spawnCoinTimer; //reset the timer
            spawnLocation = new Vector3(Random.Range(-world.x, world.x), Random.Range(-world.y, world.y), 0); //pick a new location for the next coin to spawn
        }

    }
}
