using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the player moves horizontally
    private Animator animator;
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip coinSound; // Sound clip to play when colliding with a coin
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>(); // Assign the Animator component
    }

    void Update()
    {
        // Get input from horizontal axis (A/D keys or left/right arrow keys)
        float moveInput = Input.GetAxis("Horizontal");

        // Calculate movement amount
        float moveAmount = moveInput * moveSpeed * Time.deltaTime;

        // Move the player horizontally
        Vector3 move = new Vector3(moveAmount, 0f, 0f);
        rb.MovePosition(rb.position + move);

        // Check for jump input (Spacebar)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play the audio
            audioSource.Play();
            // Set the isJumping parameter in the Animator to true
            animator.SetBool("isJumping", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            // Set the isJumping parameter in the Animator to false when spacebar is released
            animator.SetBool("isJumping", false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object tagged as "Coin"
        if (collision.gameObject.CompareTag("Coin"))
        {
            // Play the coin sound
            AudioSource.PlayClipAtPoint(coinSound, collision.transform.position);
        }
    }
}
