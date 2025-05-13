using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public TMP_Text healthGUI;
    public Transform player;
    public int currentHealth;
    public int maxHealth = 100;
    public GameObject deathEffect;
    public int damage = 40;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            TakeDamage(damage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthGUI.text = currentHealth.ToString();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
