using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject object_to_spawn;
    [SerializeField] float velocityMax;
    [SerializeField] float velocityMin;


    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 3f;

    // Start is called before the first frame update
    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            float timeBetweenSpawnsInSeconds = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            float velocity_random = Random.Range(velocityMin, velocityMin);
            yield return new WaitForSeconds(timeBetweenSpawnsInSeconds);       // co-routines
   
            GameObject newObject = Instantiate(object_to_spawn.gameObject, transform.position, Quaternion.identity);
            newObject.GetComponent<mover>().SetVelocity(new Vector3(velocity_random,0,0));

        }
    }
}
