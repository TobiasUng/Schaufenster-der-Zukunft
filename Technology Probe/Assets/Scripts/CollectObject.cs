using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public List<GameObject> collectedObjects = new List<GameObject>();
    public GameObject parentObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if(col.tag == "Symbol")
        {
            collectedObjects.Add(col.transform.gameObject);
            col.transform.gameObject.SetActive(false);
            col.transform.parent = parentObject.transform;
        }
        
    }
}
