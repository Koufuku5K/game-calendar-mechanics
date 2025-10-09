using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform followTarget, lookTarget;
    public float followSpeed = 10f;

    // Late update prevents jittery camera movements
    private void LateUpdate()
    {
        Vector3 targetPos = followTarget.position;
        // Update camera position
        transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);

        transform.LookAt(lookTarget);
    }
}
