using UnityEngine;
using System.Collections;

public class tubeTrigger : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("GameSceneObjects").GetComponent<simpleMove>().enableObjectScroll = true;
        GameObject.Find("RepeatingBackground1").GetComponent<BackgroundScroller>().enableBackgroundScroll = true;
        GameObject.Find("RepeatingBackground2").GetComponent<BackgroundScroller>().enableBackgroundScroll = true;
    }
}
