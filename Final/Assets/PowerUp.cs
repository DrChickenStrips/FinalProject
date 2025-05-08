using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int bulVal=2;
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
       // Instantiate(pickupEffect, transform.position, transform.rotation);
        player.GetComponent<Weapon>().AddAMMO(bulVal);
       


        Destroy(gameObject);
    }
}
