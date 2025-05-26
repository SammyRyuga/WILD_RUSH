using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioClip coinSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Score.coinCount += 1;
            Destroy(gameObject);
        }
    }
}