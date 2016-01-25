using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {

    public bool enableBackgroundScroll = false;

    public float scrollSpeed;
    public float tileSizeY;

    public Vector2 startPosition;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (enableBackgroundScroll)
        {
            float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeY);
            transform.position = startPosition + Vector2.up * newPosition;
        }
    }
}
