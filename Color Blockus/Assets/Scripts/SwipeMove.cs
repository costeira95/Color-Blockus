using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMove : MonoBehaviour {

    private Vector2 startTouchPos, endTouchPos, targetPos;
    public float speed;
    public float MaxY, MinY;
    public float Yincrement;
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPos = Input.GetTouch(0).position;
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPos = Input.GetTouch(0).position;
            if ((endTouchPos.y < startTouchPos.y) && transform.position.y > MinY)
                targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            if ((endTouchPos.y > startTouchPos.y) && transform.position.y < MaxY)
                targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
	}
}
