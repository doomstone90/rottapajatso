using UnityEngine;
using System.Collections;

public class simpleMove : MonoBehaviour {

    public bool enableObjectScroll = false;
    public float movementSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (enableObjectScroll)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
	}
}
