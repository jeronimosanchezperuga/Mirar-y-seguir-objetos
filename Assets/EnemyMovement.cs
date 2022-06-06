using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public Transform targetTR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //transform.LookAt();
        //transform.Translate(transform.forward * speed * Time.deltaTime);
        var step = speed * Time.deltaTime;
        FollowUsingMoveTowards(step);
    }

    void FollowUsingMoveTowards(float followSpeed)
    {
        transform.position  = Vector3.MoveTowards(transform.position,targetTR.position,followSpeed);
    }
}
