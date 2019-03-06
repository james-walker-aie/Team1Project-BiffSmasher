using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
  

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other != null)
        {
            if (other.gameObject.tag == "Enemy")
            {
                if (other.gameObject.GetComponent<EnemyMovement>().health > 0)
                {
                    Debug.Log("current health " + other.gameObject.GetComponent<EnemyMovement>().health);
                    other.gameObject.GetComponent<EnemyMovement>().health--;
                    Debug.Log("hurt enemy " + other.gameObject.GetComponent<EnemyMovement>().health);
                    // knockback direction
                    Vector3 hitDir = other.transform.position - this.transform.position;
                   // hitDir = hitDir.normalized;
                 //   other.gameObject.GetComponent<EnemyMovement>().Knockback(hitDir);
                    
                }

                if (other.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave1)
                {
                    Debug.Log("destroy enemy");
                    GameManager.fightZone1Enemies--;
                    Destroy(other.gameObject, .1f);
                   
                }

                if (other.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave2)
                {
                    Debug.Log("destroy enemy");
                    Destroy(other.gameObject, .1f);
                    GameManager.fightZone2Enemies--;


                }
                if (other.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave3)
                {
                    Debug.Log("destroy enemy");
                    Destroy(other.gameObject, .1f);
                    GameManager.fightZone3Enemies--;


                }
                if (other.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave4)
                {
                    Debug.Log("destroy enemy");
                    Destroy(other.gameObject, .1f);
                    GameManager.fightZone4Enemies--;


                }
            }
            
        }
    }
}
