using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manthree : MonoBehaviour {

    private float health = 3;
    public GameObject secondlife;
    public GameObject thirdlife;
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
            if (health == 2)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = secondlife.GetComponent<SpriteRenderer>().sprite;
            }
            if(health == 1)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = thirdlife.GetComponent<SpriteRenderer>().sprite;
            }
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    public static int scoring()
    {
        return scores;
    }

}
