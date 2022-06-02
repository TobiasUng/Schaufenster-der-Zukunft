using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    // Start is called before the first frame update
    public float MaxAngleDeflection = 15.0f;
    public float SpeedOfPendulum = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = MaxAngleDeflection * Mathf.Sin(Time.time * SpeedOfPendulum);
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
}
