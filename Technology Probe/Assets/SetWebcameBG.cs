using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetWebcameBG : MonoBehaviour
{

    static WebCamTexture backCam;
    // Start is called before the first frame update
    void Start()
    {
        if (backCam == null)
            backCam = new WebCamTexture();

        GetComponent<Renderer>().material.mainTexture = backCam;

        if (!backCam.isPlaying)
            backCam.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
