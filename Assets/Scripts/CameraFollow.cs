using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target object for the camera to follow
    public Vector3 positionOffset = new Vector3(0f, 5f, -10f); // Offset from the target object for position
    public Vector3 rotationOffset = new Vector3(30f, 0f, 0f); // Offset for rotation
    public float smoothTime = 0.5f; // Increased smoothing time for the camera movement
    private Vector3 velocity = Vector3.zero; // Velocity for SmoothDamp

    void LateUpdate()
    {
        if (target == null)
            return;

        // Calculate desired position with position offset relative to the target object
        Vector3 desiredPosition = target.position + positionOffset;

        // Smoothly move the camera to the desired position
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
        transform.position = smoothedPosition;

        // Calculate desired rotation with rotation offset
        Quaternion desiredRotation = Quaternion.LookRotation(target.position - transform.position) * Quaternion.Euler(rotationOffset);

        // Apply rotation
        transform.rotation = desiredRotation;
    }
}
