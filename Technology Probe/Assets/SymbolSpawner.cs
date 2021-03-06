using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolSpawner : MonoBehaviour
{
    public GameObject[] symbolPrefabs;
    public int symbol_count = 0;
    public List<int> sequence = new List<int>();
    public Transform[] spawnPoints;

    public float startForce = 1f;
    public float startTorque = 3f;

    public float minDelay = 0.1f;
    public float maxDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < symbolPrefabs.Length; i++)
        {
            for(int j = 0; j < symbol_count; j++)
            {
                sequence.Add(i);
            }
        }

        StartCoroutine(SpawnFruits());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnFruits()
    {
        while (sequence.Count > 0)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            //int index = Random.Range(0, symbolPrefabs.Length);
            int index = Random.Range(0, sequence.Count);
           

            GameObject spawnedFruit = Instantiate(symbolPrefabs[sequence[index]], spawnPoint.position, spawnPoint.rotation);
            sequence.RemoveAt(index);


            spawnedFruit.GetComponent<Rigidbody2D>().AddForce(-spawnedFruit.transform.up * startForce, ForceMode2D.Impulse);
            spawnedFruit.GetComponent<Rigidbody2D>().AddTorque(startTorque, ForceMode2D.Impulse);
            //Destroy(spawnedFruit, 5f);

        }
    }
}
