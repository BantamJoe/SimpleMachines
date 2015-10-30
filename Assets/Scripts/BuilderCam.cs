using UnityEngine;
using System.Collections;

public class BuilderCam : MonoBehaviour {

    private Camera cam;

	// Use this for initialization
	void Start () {
        this.cam = GetComponent<Camera>();
        cam.orthographic = true;
    }
	
	// Update is called once per frame
	void Update () {
        cam.enabled = true;
	}
}
