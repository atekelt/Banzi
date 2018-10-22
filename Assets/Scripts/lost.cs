using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lost : MonoBehaviour {
    public static bool loststat = false;
	void OnCollisionEnter2D(Collision2D coll)
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel("lost");
        loststat = true;
#pragma warning restore CS0618 // Type or member is obsolete
    }
    
}
