using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelReel : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			if(transform.position.x == -1.457118 && transform.position.z == -0.6631815)
			{
			transform.Translate(Vector3.left * 2, Space.World);
			transform.Translate(Vector3.back, Space.World);
			}
			
			else if(transform.position.x == -2)
			{
			transform.Translate(Vector3.right * 2, Space.World);
			transform.Translate(Vector3.back, Space.World);
			}
			
			else if(transform.position.x == -1.457118 && transform.position.z == -2)
			{
			transform.Translate(Vector3.right * 2, Space.World);
			transform.Translate(Vector3.forward, Space.World);
			}
			
			else if(transform.position.x == -2)
			{
			transform.Translate(Vector3.left * 2, Space.World);
			transform.Translate(Vector3.forward, Space.World);
			}
		}
    }
}
