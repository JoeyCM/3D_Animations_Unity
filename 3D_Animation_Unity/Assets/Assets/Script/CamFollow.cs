using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;  // Assign your model's transform to this variable
    public float offsetX = 0f;  // Adjust the x-axis offset as needed
    public float offsetY = 2f;  // Adjust the y-axis offset as needed
    public float offsetZ = -5f; // Adjust the z-axis offset as needed
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    void Start()
    {
        // Store the original position and rotation at the start
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    void Update()
    {
        if (target != null)
        {
            // Set the camera's position to be offset from the target's position with adjusted offsets
            transform.position = new Vector3(target.position.x + originalPosition.x + offsetX, target.position.y + originalPosition.y + offsetY, target.position.z + originalPosition.z + offsetZ);

            // Make the camera look at the target
            transform.LookAt(target);
        }
    }
}
