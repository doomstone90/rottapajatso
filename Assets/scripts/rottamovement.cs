using UnityEngine;
using System.Collections;

public class rottamovement : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Rigidbody2D.AddForce(Vector2.right);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 5), ForceMode2D.Impulse);
        }
	}
}
