using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Camera BuilderCam;
    public Camera ActionCam;

	// Use this for initialization
	void Start () {
        BuilderCam.enabled = true;
        ActionCam.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void Action()
    {
        ActionCam.enabled = true;
        BuilderCam.enabled = false;
    }
}
