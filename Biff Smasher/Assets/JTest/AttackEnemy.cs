using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col != null)
        {
            if ((col.gameObject.tag == "Enemy") && (CharacterController2D.instance.slashAttack == true || CharacterController2D.instance.thrustAttack == true ))

            {
                Debug.Log("punched " + col.gameObject.tag);
                if (col.gameObject.GetComponent<EnemyMovement>().health > 0 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    // knockback direction
                    Vector2 hitDir = col.transform.position - this.transform.position;
                    hitDir = hitDir.normalized;
                    col.gameObject.GetComponent<EnemyMovement>().Knockback(hitDir);
                    // hurt enemy
                    Debug.Log("current health " + col.gameObject.GetComponent<EnemyMovement>().health);
                    col.gameObject.GetComponent<EnemyMovement>().HurtEnemy();
                    Debug.Log("hurt enemy " + col.gameObject.GetComponent<EnemyMovement>().health);

                   

                }

                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave1 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    GameManager.instance.fightZone1Enemies--;
                    Destroy(col.gameObject, .1f);

                }

                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave2 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.instance.fightZone2Enemies--;


                }
                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave3 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.instance.fightZone3Enemies--;


                }
                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave4 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.instance.fightZone4Enemies--;


                }
            }

        }
    }


}
