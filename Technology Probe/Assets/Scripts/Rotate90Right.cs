using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate90Right : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotateRight()
    {
        transform.Rotate(new Vector3(0, 45, 0));
    }

}
