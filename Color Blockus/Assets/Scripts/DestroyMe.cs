﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour {

    public float time = 0.5f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, time);
	}
}
