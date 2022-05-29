using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public UDPReceive udpReceive;
    public Camera camera;
   
    Vector3 previousPos, nextPos, Pos;

    void Start()
    {
        previousPos = gameObject.transform.localPosition;
        
    }

    // Update is called once per frame
    void Update()
    {

        string data = udpReceive.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length - 1, 1);
        //(255,361,50012) example data (x,y,area)
        string[] info = data.Split(',');

        float x = 5-float.Parse(info[0]) / 100;
        float y = float.Parse(info[1]) / 100 - 3;
        //float z = -10 + float.Parse(info[2]) / 1000;


        //x = float.Parse(info[0]);
        //y = Camera float.Parse(info[1])



        Pos = camera.ScreenToWorldPoint(new Vector3(float.Parse(info[0]), float.Parse(info[1]), 0));

        print(Pos);
        //
        //print("x:" + float.Parse(info[0]) + ", y:" + float.Parse(info[1]));
        //
        //print(Input.mousePosition);

        nextPos = new Vector3(-Pos.x, Pos.y, gameObject.transform.localPosition.z);

        gameObject.transform.localPosition = Vector3.Lerp(previousPos, nextPos, 0.2f);

        previousPos = gameObject.transform.localPosition;


    }
}