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
        spawnLocation = new Vector3(Random.Range(-world.x, world.x), Random.Range(-world.y, world.y), 0);
        spawnTimer = spawnCoinTimer;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if(spawnCoinTimer <= 0)
        {
            Coin coin = Instantiate(coinPrefab, spawnLocation, Quaternion.identity);
            spawnTimer = spawnCoinTimer;
            spawnLocation = new Vector3(Random.Range(-world.x, world.x), Random.Range(-world.y, world.y), 0);
        }

    }
}
