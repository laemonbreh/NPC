using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //NPCs health
    public int health = 5;
    //NPCs Level location
    public int level = 1;
    //NPCs Speed
    public float speed = 1.2f;

    void Start()
    {
        health += level;
        print("Health:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector newPosition.Z = transform.position;
        //newPosition.Z += speed * Time.deltaTime;
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}