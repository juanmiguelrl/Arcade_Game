using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnRate = 1f;
    public float spawnRate2 = 1f; 

    public GameObject hexagonprefab;
    public GameObject obs1;

    private float nextTimeToSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn) {
            int r = Random.Range(1,3); //se cambia por un numero aleatorio 1 o 2 o algo así(igual reduciendo cada vez que aparece un elemento la posibilidad de que vuelva a aparecer)
            Debug.Log("r = " + r);
            if (r == 1) {
                Instantiate(hexagonprefab, Vector3.zero, Quaternion.identity);
                 nextTimeToSpawn = Time.time + 1f / spawnRate;
            }
            if (r == 2) {
                Instantiate(obs1, Vector3.zero, Quaternion.identity);
                 nextTimeToSpawn = Time.time + 1f / spawnRate2;
            }
           //new Hexagon(this);
        }
        
    }
}
