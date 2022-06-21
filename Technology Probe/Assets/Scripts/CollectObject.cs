using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    //public static List<GameObject> collectedObjects = new List<GameObject>();
    public static Dictionary<string, int> collectedObjects = new Dictionary<string, int>
    {
        {"Apple", 0},
        {"Avocado", 0},
        {"Atom", 0},
        {"Bike", 0},
        {"Car", 0},
        {"Plane", 0},
        {"Train", 0},
        {"Windmill", 0}
    };
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
            //collectedObjects.Add(col.transform.gameObject);
            collectedObjects[col.name]++;
            col.transform.gameObject.SetActive(false);
            col.transform.parent = parentObject.transform;
        }
        
    }

    private void OnApplicationQuit()
    {
        print(collectedObjects["Apple"]);
        print(collectedObjects["Avocado"]);
        print(collectedObjects["Atom"]);
        print(collectedObjects["Bike"]);
    }
}
