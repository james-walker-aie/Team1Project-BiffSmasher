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
                Debug.Log("punched " + col.gameObject.tag);
                if (col.gameObject.GetComponent<EnemyMovement>().health > 0 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("current health " + col.gameObject.GetComponent<EnemyMovement>().health);
                    col.gameObject.GetComponent<EnemyMovement>().health--;
                    Debug.Log("hurt enemy " + col.gameObject.GetComponent<EnemyMovement>().health);

                    // knockback direction
                    Vector2 hitDir = col.transform.position - this.transform.position;
                    hitDir = hitDir.normalized;
                    col.gameObject.GetComponent<EnemyMovement>().Knockback(hitDir);

                }

                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave1 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    GameManager.fightZone1Enemies--;
                    Destroy(col.gameObject, .1f);

                }

                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave2 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.fightZone2Enemies--;


                }
                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave3 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.fightZone3Enemies--;


                }
                if (col.gameObject.GetComponent<EnemyMovement>().health <= 0 && FightZone.wave4 && col.gameObject.GetComponent<EnemyMovement>().isDead == false)
                {
                    Debug.Log("destroy enemy");
                    col.gameObject.GetComponent<EnemyMovement>().isDead = true;
                    Destroy(col.gameObject, .1f);
                    GameManager.fightZone4Enemies--;


                }
            }

        }
    }


}
