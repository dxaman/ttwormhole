using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public AudioSource collectSound;
    public Transform player; 
    public SlowDownTime timeSlower;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            collectSound.Play();
            timeSlower.DoSlowmotion();
            Destroy(gameObject);
        }
        
    }
}
