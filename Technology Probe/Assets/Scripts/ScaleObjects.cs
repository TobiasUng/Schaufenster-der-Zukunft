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
        apple.transform.localScale = new Vector3 (CollectObject.collectedObjects["Apple"], CollectObject.collectedObjects["Apple"], CollectObject.collectedObjects["Apple"])/5;
        avocado.transform.localScale = new Vector3 (CollectObject.collectedObjects["Avocado"], CollectObject.collectedObjects["Avocado"], CollectObject.collectedObjects["Avocado"])/5;
        train.transform.localScale = new Vector3 (CollectObject.collectedObjects["Train"], CollectObject.collectedObjects["Train"], CollectObject.collectedObjects["Train"])/5;
        plane.transform.localScale = new Vector3 (CollectObject.collectedObjects["Plane"], CollectObject.collectedObjects["Plane"], CollectObject.collectedObjects["Plane"])/5;
        car.transform.localScale = new Vector3 (CollectObject.collectedObjects["Car"], CollectObject.collectedObjects["Car"], CollectObject.collectedObjects["Car"])/5;
        bicyle.transform.localScale = new Vector3 (CollectObject.collectedObjects["Bike"], CollectObject.collectedObjects["Bike"], CollectObject.collectedObjects["Bike"])/5;
        windmill.transform.localScale = new Vector3 (CollectObject.collectedObjects["Windmill"], CollectObject.collectedObjects["Windmill"], CollectObject.collectedObjects["Windmill"])/5;
        atom.transform.localScale = new Vector3 (CollectObject.collectedObjects["Atom"], CollectObject.collectedObjects["Atom"], CollectObject.collectedObjects["Atom"])/5;
    }
}
