using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BreakableSpawn : MonoBehaviour
{
    public GameObject cubeSlicedPrefab;
	Vector3 cubePosition = new Vector3 (5f,0f,0f);
    public float startForce = 5f;

    [SerializeField] private UnityEvent spawnEvent;


    Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Blade")
        {
            spawnEvent.Invoke();
			Destroy (cubeSlicedPrefab.gameObject, 5f);
			    float time = 2.0f;
				time -= Time.deltaTime;
			cubeSlicedPrefab = (GameObject)Instantiate (cubeSlicedPrefab, cubePosition, Quaternion.identity);
            
        }
    }


    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {

    }
}
