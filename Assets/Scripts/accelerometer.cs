using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometer : MonoBehaviour
{
    // Start is called before the first frame update
  CharacterController controller;
    Vector3 moveVector;
    float speed = 10.0f;
    private bool isDead = false;
    private float startTime;
    private float animationDuration = 3.0f;

    // Start is called before the first frame update
     void Start()
    {
        controller=GetComponent<CharacterController>();
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
            return;

      /*  if (Time.time - startTime < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }*/

        moveVector=Vector3.zero;

        moveVector.x=Input.acceleration.x*speed*3;
        moveVector.y=Input.acceleration.y*speed*3;
        moveVector.z=speed;
        controller.Move(moveVector*Time.deltaTime);
        
    }
    public void SetSpeed(float modifier)
    {
        speed = 10.0f + modifier;
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.point.z > transform.position.z )
        {
            Death();
        }
        
    }
    private void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}
