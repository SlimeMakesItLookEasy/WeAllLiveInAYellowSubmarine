using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEvilFish : MonoBehaviour
{

    public GameObject Submarine; //the enemy's target
    private Transform target;
    public float moveSpeed = 5; //move speed
    public float rotationSpeed = 5; //speed of turning
    public Rigidbody rb;
    Vector3 dir;
    private GameObject TestEnemyFish;
    private float distance;
    private float toClose; 

    // Start is called before the first frame update
    void Start()
    {
        TestEnemyFish = GameObject.FindGameObjectWithTag("TestEnemyFish");
        rb = GetComponent<Rigidbody>();
        Submarine = GameObject.FindGameObjectWithTag("Submarine");
        target = Submarine.transform; //GameObject.FindGameObjectWithTag("Submarine").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);
        if (distance <= toClose)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.03f);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);

        }


        
    }
}

