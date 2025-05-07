using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        Weapon currentAmmo; 
        
           currentAmmo = 10;
            


        Destroy(gameObject);
    }
}
