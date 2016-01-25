using UnityEngine;
using System.Collections;

public class cameraTransform : MonoBehaviour {

    public bool enableCameraTransform = false;

    public Transform camera;
    public Transform playerPos;
    public float speed = 1.0f;
    private float journeyLength;

	// Use this for initialization
	void Start () {
        journeyLength = Vector2.Distance(camera.position, playerPos.position);
	}
	
	// Update is called once per frame
	void Update () {
        if (enableCameraTransform) { 
            float distCovered = Time.time * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector2.Lerp(camera.position, playerPos.position, fracJourney);
        }
    }
}
