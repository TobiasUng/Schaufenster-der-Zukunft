using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    public Transform[] spawnPoints;

    public float startForce = 1f;
    public float startTorque = 3f;

    public float minDelay = 0.1f;
    public float maxDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnFruits()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            int index = Random.Range(0, fruitPrefabs.Length);
            print(index);

            GameObject spawnedFruit = Instantiate(fruitPrefabs[index], spawnPoint.position, spawnPoint.rotation);
            spawnedFruit.GetComponent<Rigidbody2D>().AddForce(-spawnedFruit.transform.up * startForce, ForceMode2D.Impulse);
            spawnedFruit.GetComponent<Rigidbody2D>().AddTorque(startTorque, ForceMode2D.Impulse);
            //Destroy(spawnedFruit, 5f);

        }
    }
}
