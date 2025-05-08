using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Weapon : MonoBehaviour
{
    public TMP_Text ammoGUI;
        public Transform firePoint;
        public GameObject bulletPrefab;
        public int maxAmmo = 10;
        public int currentAmmo;


    void Start()
    {
        currentAmmo = maxAmmo;

    } 
    // Update is called once per frame
    void Update()
    {
        ammoGUI.text = currentAmmo.ToString();
        if (currentAmmo <= 0)
        {
            return;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    
    }

    void Shoot ()
    {
        currentAmmo--;

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void AddAMMO(int val)
    {
        currentAmmo = currentAmmo+val;
    }
}  
