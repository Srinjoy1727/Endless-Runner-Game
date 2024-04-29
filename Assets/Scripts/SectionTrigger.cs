using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public GameObject roadSection;
    public float delay = 3f; // Delay between instantiations
    public float repeatRate = 3f; // Rate of repetition
    private Vector3 nextSpawnPoint = Vector3.zero; // Initial spawn point at (0, 0, 0)

    void Start()
    {
        // Call the method repeatedly with a delay
        InvokeRepeating("SpawnRoadSection", delay, repeatRate);
    }

    // Method to spawn the road section
    void SpawnRoadSection()
    {
        // Instantiate the road section at the current spawn point
        GameObject newRoadSection = Instantiate(roadSection, nextSpawnPoint, Quaternion.identity);

        // Adjust the next spawn point
        nextSpawnPoint += new Vector3(0, 0, 154); //
    }

    
    
}