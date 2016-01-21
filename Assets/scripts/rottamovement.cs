using UnityEngine;
using System.Collections;

public class Rottamovement : MonoBehaviour {

    Vector2 rat;
    Vector2 mouse;
    GameObject Rat;
    public Vector2 jumpDirection;
    public float jumpForce;
    //GameObject player = GameObject.Find("rotta");
    JumpScript jumpScript;

    //GameObject.FindGameObjectWithTag("MainCamera");
    //rat = GameObject.Find("rotta").transform.position;
    
	// Use this for initialization
    void Awake() {

    }

	void Start() {


        Rat = GameObject.FindGameObjectWithTag("Player");
        jumpScript = Rat.GetComponent<JumpScript>();

	}
	
	// Update is called once per frame
	void Update() {

            //GetComponent.FindWithTag("Player");
            rat = GameObject.Find("rotta").transform.position;
           
            //mouse = GetComponent<Camera>().WorldToScreenPoint(Input.mousePosition);
            mouse = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
            Debug.DrawLine(rat, mouse, Color.red);

        /*if (Input.GetMouseButtonDown(0)){
            OnMouseUp();
            //Vector2 pos = GetComponent<Camera>().transform.position;
            //Vector2 dir = (this.transform.position - GetComponent<Camera>().transform.position).normalized;
            //Debug.DrawLine (pos, pos + dir * 10, Color.red, Mathf.Infinity);
            
        }*/
        if (Input.GetMouseButtonDown(0))
        {
            jumpDirection = mouse-rat;
            jumpForce = 5.0f;
            //Debug.Log("clicked");
            //Rigidbody2D.AddForce(Vector2.right);
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 5), ForceMode2D.Impulse);
            //jumpScript jump = GetComponent<jumpScript>();
            //jump.Jump();
            //Rat.GetComponent<JumpScript>().Jump();
            jumpScript.Jump();
        }

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
