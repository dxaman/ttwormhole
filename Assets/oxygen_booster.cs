using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygen_booster : MonoBehaviour
{
    public GameObject pickupEffect;
	

    void OnTriggerEnter (Collider other)
    {
    	if (other.CompareTag("Player"))
    	{
    		Pickup(other);
    	}
    }

    void Pickup(Collider player)
    {
    	Instantiate(pickupEffect, transform.position, transform.rotation);

    	player_oxygen stats = player.GetComponent<player_oxygen>();
    	stats.currentHealth+=250;

    	Destroy(gameObject);
    }
}
