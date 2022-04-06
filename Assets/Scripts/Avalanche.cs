using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avalanche : MonoBehaviour {
    public GameObject boulderPrefab;
    public float respawnDelay = 15f;
    public int boulderNumber = 50;

    private float leftEndpoint;
    private float rightEndpoint;
    private float spawnHeight;


    // Start is called before the first frame update
    void Start() {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;         //turn off rendering, we dont want to see this bar
        leftEndpoint = transform.position.x - transform.lossyScale.x / 2;
        rightEndpoint = transform.position.x + transform.lossyScale.x / 2;
        spawnHeight = transform.position.y;
        //start boulder routine
        StartCoroutine(SpawnBoulderWave());
    }


    //Routine that spawns a wave of boulders ever "respawnDelay" seconds
    IEnumerator SpawnBoulderWave() {
        while(true) {
            yield return new WaitForSeconds(respawnDelay);
            //once time is up, spawn boulders
            for(int i=0; i<boulderNumber; i++) { 
                GameObject a = Instantiate(boulderPrefab) as GameObject;
                a.transform.position = new Vector2(Random.Range(leftEndpoint, rightEndpoint) , spawnHeight);
                yield return null;
            }
            Debug.Log("Spawned Avalanche");
        }
    }
}
