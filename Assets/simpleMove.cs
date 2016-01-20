using UnityEngine;
using System.Collections;

public class simpleMove : MonoBehaviour {

    public bool enabled = false;
    public float movementSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (enabled)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
	}
}
