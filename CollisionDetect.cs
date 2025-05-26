using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collisionSFX;
    [SerializeField] GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());
    }
    
    IEnumerator CollisionEnd()
    {
        collisionSFX.Play();
        player.GetComponent<PlayerMovement>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Stumble Backwards");
        yield return new WaitForSeconds(3f);
        fadeOut.SetActive(true);
        SceneManager.LoadScene(0);
    }
}