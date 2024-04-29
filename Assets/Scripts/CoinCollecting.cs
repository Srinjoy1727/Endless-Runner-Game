using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollecting : MonoBehaviour
{
    public int coins;
    public AudioClip coinCollectSound; // Sound to play when a coin is collected
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected");
            coins = coins + 1;
            other.gameObject.SetActive(false);
            PlayCoinCollectSound(); // Play the sound when a coin is collected
        }
    }

    // Function to play the coin collection sound
    void PlayCoinCollectSound()
    {
        if (coinCollectSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(coinCollectSound);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

