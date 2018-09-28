using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Sprite amarelo;
    public Sprite lilas;
    public Sprite azul;
    public string currentColor;

    // Use this for initialization
    void Start () {
        SetRandomColor();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void SetRandomColor()
    {
        int index = Random.Range(0, 3);
        switch (index)
        {
            case 0:
                currentColor = "amarelo";
                GetComponent<SpriteRenderer>().sprite = amarelo;
                break;
            case 1:
                currentColor = "azul";
                GetComponent<SpriteRenderer>().sprite = azul;
                break;
            case 2:
                currentColor = "lilas";
                GetComponent<SpriteRenderer>().sprite = lilas;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != currentColor)
            Debug.Log("YOU DIED!");
        else
            SetRandomColor();
    }

}
