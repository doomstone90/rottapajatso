using UnityEngine;
using System.Collections;

public class tubeTrigger : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("GameSceneObjects").GetComponent<simpleMove>().enabled = true;
    }
}
