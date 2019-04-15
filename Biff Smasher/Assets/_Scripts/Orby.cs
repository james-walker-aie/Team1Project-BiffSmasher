using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orby : MonoBehaviour
{

    [SerializeField] Transform Waypoint;

    [SerializeField] float rotateZ = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveToward();
        Rotate();
    }

    void Rotate()
    {
        gameObject.transform.Rotate(0, 0, rotateZ * Time.deltaTime);
    }

    void MoveToward()
    {
        Waypoint = GameObject.FindGameObjectWithTag("Orby").transform;
        transform.position = Vector3.MoveTowards(transform.position, Waypoint.transform.position, 1);
    }
}
