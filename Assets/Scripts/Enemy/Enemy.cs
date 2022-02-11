using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ScriptableObjectEnemy ennemyInfo;
    [SerializeField]int health;
    public GameObject deathEffect;
    //FX 
    [SerializeField] GameObject hitEffect = null;
    

    void Start ()
    {
        health = ennemyInfo.health;
    }

   
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("It Take damages" + damage);
        
       
        if (health <= 0)
        {
            StartCoroutine("destroyEffect");
            Die();
            //FX//
            //hitEffect.Play();
            Instantiate(deathEffect, gameObject.transform.position, Quaternion.identity); // Spawn at enemy loc 
            
        }
    }

    void Die()
    {
        // Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    IEnumerator destroyEffect()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(hitEffect);
    }
}
