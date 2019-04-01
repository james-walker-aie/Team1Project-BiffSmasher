using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Transition : MonoBehaviour
{
    [SerializeField] string levelTransit = "LEVEL TO BE LOADED";
    [SerializeField] GameObject player;
    [SerializeField] Animator portalTransitAnimation;
    // pause length between dialogue
    [SerializeField] float timeBetweenText = 1f;

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(SceneTransitionCo());
        }
    }

    public IEnumerator SceneTransitionCo()
    {

        player.SetActive(false);

        yield return new WaitForSeconds(timeBetweenText);

        portalTransitAnimation.SetTrigger("OpenPortal");

        yield return new WaitForSeconds(timeBetweenText);

        portalTransitAnimation.SetTrigger("PlayerTransition");

        yield return new WaitForSeconds(timeBetweenText);

        SceneManager.LoadScene(levelTransit);
    }
}
