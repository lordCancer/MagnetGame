using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public SwipeManager swipeControl;
    public float speed;
    private Transform playerTransform;
   // private Vector2 desiredPos;

	// Use this for initialization
	void Start () {
        playerTransform = GetComponent<Transform>();
       // desiredPos = playerTransform.position;

	}
	
	// Update is called once per frame
	void Update () {

        //if (swipeControl.SwipeLeft)
           
        if (swipeControl.SwipeRight)
                iTween.MoveTo(this.gameObject, iTween.Hash("path", iTweenPath.GetPath("Line"), "time", 5));

        /*if (swipeControl.SwipeUp)
            desiredPos += Vector2.up;
        if (swipeControl.SwipeDown)
            desiredPos += Vector2.down;*/

        //playerTransform.transform.position = Vector2.MoveTowards(playerTransform.transform.position, desiredPos, speed * Time.deltaTime);

        //if (swipeControl.Tap)
          //  Debug.Log();
    }
}
