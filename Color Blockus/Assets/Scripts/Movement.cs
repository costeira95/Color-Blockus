using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public GameObject player;

    Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;

    bool isUpPressed = false;
    bool isDownPressed = false;
	// Use this for initialization
	void Start () {
        targetPos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        player.transform.position = Vector2.MoveTowards(player.transform.position, targetPos, speed * Time.deltaTime);

        if (player.transform.position.y < maxHeight && isUpPressed)
        {
            targetPos = new Vector2(player.transform.position.x, player.transform.position.y + Yincrement);
            CancelPressed();
        }

        if (player.transform.position.y > minHeight && isDownPressed)
        {
            targetPos = new Vector2(player.transform.position.x, player.transform.position.y - Yincrement);
            CancelPressed();
        }
    }

    public void PressUp()
    {
        isUpPressed = true;
        isDownPressed = false;
    }
    public void PressDown()
    {
        isUpPressed = false;
        isDownPressed = true;
    }

    private void CancelPressed()
    {
        isUpPressed = false;
        isDownPressed = false;
    }

}
