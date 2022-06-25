using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObjects : MonoBehaviour
{
    public GameObject apple;
    public GameObject avocado;
    public GameObject train;
    public GameObject plane;
    public GameObject car;
    public GameObject bicyle;
    public GameObject windmill;
    public GameObject atom;
    

    public void Awake()
    {
        apple.transform.localScale = new Vector3 (CollectObject.collectedObjects["Apple"], CollectObject.collectedObjects["Apple"], CollectObject.collectedObjects["Apple"]);
        avocado.transform.localScale = new Vector3 (CollectObject.collectedObjects["Avocado"], CollectObject.collectedObjects["Avocado"], CollectObject.collectedObjects["Avocado"]);
        train.transform.localScale = new Vector3 (CollectObject.collectedObjects["Train"], CollectObject.collectedObjects["Train"], CollectObject.collectedObjects["Train"]);
        plane.transform.localScale = new Vector3 (CollectObject.collectedObjects["Plane"], CollectObject.collectedObjects["Plane"], CollectObject.collectedObjects["Plane"]);
        car.transform.localScale = new Vector3 (CollectObject.collectedObjects["Car"], CollectObject.collectedObjects["Car"], CollectObject.collectedObjects["Car"]);
        bicyle.transform.localScale = new Vector3 (CollectObject.collectedObjects["Bike"], CollectObject.collectedObjects["Bike"], CollectObject.collectedObjects["Bike"]);
        windmill.transform.localScale = new Vector3 (CollectObject.collectedObjects["Windmill"], CollectObject.collectedObjects["Windmill"], CollectObject.collectedObjects["Windmill"]);
        atom.transform.localScale = new Vector3 (CollectObject.collectedObjects["Atom"], CollectObject.collectedObjects["Atom"], CollectObject.collectedObjects["Atom"]);
    }
}
