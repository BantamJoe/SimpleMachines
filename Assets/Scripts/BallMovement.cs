using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

    public int strength;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Push()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(new Vector3(0, 0, strength));

    }
}
