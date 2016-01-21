using UnityEngine;
using System.Collections;

public class rottamovement : MonoBehaviour {

    Vector2 rat;
    //rat = GameObject.Find("rotta").transform.position;
    Vector2 mouse = Input.mousePosition;
	// Use this for initialization
    void Awake() {

    }

	void Start() {
        rat = GameObject.Find("rotta").transform.position;
	}
	
	// Update is called once per frame
	void Update() {

        Debug.DrawLine(rat, mouse, Color.red);
        /*if (Input.GetMouseButtonDown(0)){
            OnMouseUp();
            //Vector2 pos = GetComponent<Camera>().transform.position;
            //Vector2 dir = (this.transform.position - GetComponent<Camera>().transform.position).normalized;
            //Debug.DrawLine (pos, pos + dir * 10, Color.red, Mathf.Infinity);
            
        }
        /*if (Input.GetMouseButtonDown(0))
        {
            //Rigidbody2D.AddForce(Vector2.right);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 5), ForceMode2D.Impulse);
        }*/

	}
    /*void OnMouseUp()
    {
        Ray screenToPointer = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit;

        if (GetComponent<BoxCollider2D>().RaycastHit2D(screenToPointer, out hit, Mathf.Infinity))
        {
            Vector2 theVector = (transform.position - hit.point).normalized;
            GetComponent<Rigidbody2D>().velocity = new Vector2(theVector.x * 10, theVector.y * 10);
        }
    }*/
}
