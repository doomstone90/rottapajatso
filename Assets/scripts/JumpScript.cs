using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {

    //public GameObject Camera = GameObject.Find("MainCamera");
    public Vector2 direction;
    public float force;
    Rottamovement rottamovement;
    GameObject Camera;




	// Use this for initialization
	void Start () {

        Camera = GameObject.Find("Main Camera");
        //Rottamovement rottamovement = Camera.GetComponent<Rottamovement>();
        rottamovement = Camera.GetComponent<Rottamovement>();

        //Camera = GameObject.FindGameObjectWithTag("MainCamera");
        //direction = rottamovement.jumpDirection;
        //force = rottamovement.jumpForce;
	}
	
	// Update is called once per frame
	void Update () {
        direction = rottamovement.jumpDirection;
        force = rottamovement.jumpForce;
	}

    public void Jump() {

        //force = Rottamovement.jumpForce;
        //direction = Rottamovement.jumpDirection;

        //force = rottamovement.jumpForce;
        //Debug.Log("jump force", force);
        //force = Camera.GetComponent<jumpForce>();
        //direction = Camera.GetComponent<jumpScript>.jumpDirection();
        //this<Rigidbody2D>().AddForce(direction, ForceMode2D.Impulse);
        GetComponent<Rigidbody2D>().AddForce(direction * force, ForceMode2D.Impulse);
        //Debug.Log("accessed");
    }
}
