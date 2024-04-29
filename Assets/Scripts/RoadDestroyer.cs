using UnityEngine;

public class RoadDestroyer : MonoBehaviour
{
    // Function to detect collision with the road
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is tagged as "Road"
        if (other.CompareTag("Road"))
        {
            // Destroy the collided road object
            Destroy(other.gameObject);
        }
    }
}
