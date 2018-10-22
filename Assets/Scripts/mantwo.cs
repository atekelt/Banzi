using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mantwo : MonoBehaviour {

    private float health = 2;
    public GameObject seconddlife;
    public static int scores = 0;

    void start()
    {
        scores = 0;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        laser laser = coll.gameObject.GetComponent<laser>();

        if (laser)
        {
            laser.hit();
            health -= laser.getdamage();
            if (health == 1)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = seconddlife.GetComponent<SpriteRenderer>().sprite;
                scores += 50;
            }
            if(health <= 0)
            {
                Destroy(gameObject);
                scores += 100;
            }
        }
    }

    public static int scoring()
    {
        return scores;
    }
}
