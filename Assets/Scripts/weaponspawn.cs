using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponspawn : MonoBehaviour {
    public GameObject weaponprefabright;
    public GameObject weaponprefableft;
    public GameObject bullet;
    public AudioClip pew;

    private bool directionright, directionleft;
    private GameObject gun;
    // Use this for initialization
    void Start()
    {
        directionright = true;
        directionleft = false;
        gun = Instantiate(weaponprefabright, gameObject.transform.position, Quaternion.identity) as GameObject;
        gun.transform.parent = gameObject.transform;
    }

        // Update is called once per frame
        void Update () {

        spawngun();
	}

    void spawngun()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (directionright == true)
            {
                Destroy(gun);
                gun = Instantiate(weaponprefabright, gameObject.transform.position, Quaternion.identity) as GameObject;
                gun.transform.parent = gameObject.transform;
                directionleft = false;
                GameObject bullets = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
                AudioSource.PlayClipAtPoint(pew, transform.position);
                bullets.GetComponent<Rigidbody2D>().velocity = new Vector3(10f, 0f, 0f);
            }
            else
            {
                Destroy(gun);
                gun = Instantiate(weaponprefabright, gameObject.transform.position, Quaternion.identity) as GameObject;
                gun.transform.parent = gameObject.transform;
                directionright = true;
                directionleft = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (directionleft == true)
            {
                Destroy(gun);
                gun = Instantiate(weaponprefableft, gameObject.transform.position, Quaternion.identity) as GameObject;
                gun.transform.parent = gameObject.transform;
                directionright = false;
                GameObject bullets = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
                AudioSource.PlayClipAtPoint(pew, transform.position);
                bullets.GetComponent<Rigidbody2D>().velocity = new Vector3(-10f, 0f, 0f);
            }
            else
            {
                Destroy(gun);
                gun = Instantiate(weaponprefableft, gameObject.transform.position, Quaternion.identity) as GameObject;
                gun.transform.parent = gameObject.transform;
                directionleft = true;
                directionright = false;
            }
        }
    }
}
