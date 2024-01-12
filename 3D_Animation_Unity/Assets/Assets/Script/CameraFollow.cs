using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Assign your model's transform to this variable
    public float offsetX = 0f;  // Adjust the x-axis offset as needed
    public float offsetY = 2f;  // Adjust the y-axis offset as needed
    public float offsetZ = -5f; // Adjust the z-axis offset as needed
    private Vector3 originalOffset;  // Store the original offset

    void Start()
    {
        // Store the original offset at the start
        if (target != null)
        {
            originalOffset = transform.position - target.position;
        }
    }

    void Update()
    {
        if (target != null)
        {
            // Set the camera's position to be offset from the target's position with adjusted offsets
            transform.position = new Vector3(target.position.x + originalOffset.x + offsetX, target.position.y + offsetY, target.position.z + originalOffset.z + offsetZ);

            // Make the camera look at the target
            transform.LookAt(target);
        }
    }
}
