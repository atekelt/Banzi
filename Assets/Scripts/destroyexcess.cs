﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyexcess : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(coll.gameObject);
    }
}