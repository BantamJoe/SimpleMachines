using UnityEngine;
using System.Collections;

public class Builder : MonoBehaviour {

    public GameObject selected;
    
    private Vector4 builderColor;
    private bool on = true;

	// Use this for initialization
	void Start () {
        builderColor = GetComponent<Renderer>().material.color;

        InvokeRepeating("blink", 0, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {

        if(!selected.activeInHierarchy)
        { 
            positionGameObject(selected);
        }
    }

    private void positionGameObject(GameObject obj)
    {
        var pos = transform.position; // this is where the Cube will appear when it's instantiated
        var rot = Quaternion.identity; // Quaternion.identity essentially means "no rotation"
        selected = (GameObject)Instantiate(obj, pos, rot); // The Instantiate command takes a GameObject, a Vector3 for position and a Quaternion for rotation.
    }

    void blink()
    {
        if (on)
        {
            GetComponent<Renderer>().material.color = new Vector4(1, 1, 1, 0);
            on = false;
        }
        else
        {
            GetComponent<Renderer>().material.color = builderColor;
            on = true;
        }
    }
}
