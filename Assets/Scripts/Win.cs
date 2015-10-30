using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnGUI()
    {
        if (transform.position.y < -10)
        {
            GUI.Label(new Rect(Screen.width/2, Screen.height/2, Screen.width, Screen.height), "You win!");
            Time.timeScale = 0;
        }
    }
}
