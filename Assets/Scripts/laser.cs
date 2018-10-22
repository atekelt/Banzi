using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {

    public float damage = 1;

    public float getdamage()
    {
        return damage;
    }

    public void hit()
    {
        Destroy(gameObject);
    }

}
