using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manspawnright : MonoBehaviour {
    public GameObject enemyprefabone;
    public GameObject enemyprefabtwo;
    public GameObject enemyprefabthree;

    GameObject enemyone;
    GameObject enemytwo;
    GameObject enemythree;

    private int level = 0;
    private float speed = 3;
    private float time;
    void Start()
    {
        time = Random.Range(1f, 3f);
        enemysone();

    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = Random.Range(1f, 3f);
            spawnenemys();
            level++;
        }
    }

    void spawnenemys()
    {
        if (level >= 15)
        {

            speed += 0.1f;
            int choise = Random.Range(1, 4);

            if (choise == 1)
            {
                enemysone();
            }
            else if (choise == 2)
            {
                enemystwo();
            }
            else if (choise == 3 || choise == 4)
            {
                enemysthree();
            }
        }
        else
        {
            enemysone();
        }

    }
    void enemysone()
    {
        enemyone = Instantiate(enemyprefabone, gameObject.transform.position, Quaternion.identity) as GameObject;
        enemyone.GetComponent<Rigidbody2D>().velocity = new Vector3(-speed, 0, 0);
    }

    void enemystwo()
    {
        enemytwo = Instantiate(enemyprefabtwo, gameObject.transform.position, Quaternion.identity) as GameObject;
        enemytwo.GetComponent<Rigidbody2D>().velocity = new Vector3(-speed, 0, 0);
    }

    void enemysthree()
    {
        enemythree = Instantiate(enemyprefabthree, gameObject.transform.position, Quaternion.identity) as GameObject;
        enemythree.GetComponent<Rigidbody2D>().velocity = new Vector3(-speed, 0, 0);
    }
}
