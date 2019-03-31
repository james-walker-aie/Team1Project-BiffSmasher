using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col != null)
        {
            
            if (col.gameObject.tag == "Enemy")
                
            {
                Debug.Log("punch thrown ");
                Debug.Log("punched " + col.gameObject.tag);
                if (col.gameObject.GetComponent<EnemyRetreatAndAttack>().health > 0 && col.gameObject.GetComponent<EnemyRetreatAndAttack>().isDead == false)
                {
                    // knockback direction
                  //  Vector2 hitDir = col.transform.position - this.transform.position;
                  //  hitDir = hitDir.normalized;
                   // col.gameObject.GetComponent<EnemyRetreatAndAttack>().Knockback(hitDir);
                    
                    // hurt enemy
                    Debug.Log("current health " + col.gameObject.GetComponent<EnemyRetreatAndAttack>().health);
                    col.gameObject.GetComponent<EnemyRetreatAndAttack>().HurtEnemy();
                    Debug.Log("hurt enemy " + col.gameObject.GetComponent<EnemyRetreatAndAttack>().health);

                   

                }

                if (col.gameObject.GetComponent<EnemyRetreatAndAttack>().health <= 0 && FightZone.wave1 && col.gameObject.GetComponent<EnemyRetreatAndAttack>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyRetreatAndAttack>().isDead = true;
                    GameManager.instance.fightZone1Enemies--;
                    Destroy(col.gameObject, .1f);

                }

                if (col.gameObject.GetComponent<EnemyRetreatAndAttack>().health <= 0 && FightZone.wave2 && col.gameObject.GetComponent<EnemyRetreatAndAttack>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyRetreatAndAttack>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.instance.fightZone2Enemies--;


                }
                if (col.gameObject.GetComponent<EnemyRetreatAndAttack>().health <= 0 && FightZone.wave3 && col.gameObject.GetComponent<EnemyRetreatAndAttack>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyRetreatAndAttack>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.instance.fightZone3Enemies--;


                }
                if (col.gameObject.GetComponent<EnemyRetreatAndAttack>().health <= 0 && FightZone.wave4 && col.gameObject.GetComponent<EnemyRetreatAndAttack>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyRetreatAndAttack>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.instance.fightZone4Enemies--;


                }
            }

        }
    }


}
