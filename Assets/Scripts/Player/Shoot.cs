using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    [SerializeField] GameObject muzzleFlash;
    

     void Start()
    {
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootProj();
            Instantiate(muzzleFlash, firePoint.transform.position, Quaternion.identity);
            
        }
    }
    void ShootProj()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }
}
