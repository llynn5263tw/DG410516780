using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBullet : MonoBehaviour
{
    public float speed;
    public GameObject shot;
    public float fireRate;
    public Transform shotSpawn;
    float nextFire;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }

        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -30 * Time.deltaTime * speed, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 30 * Time.deltaTime * speed, 0);
        }
    }
}