using UnityEngine;
// Visualization for object detection
public class Detector : MonoBehaviour
{
    public LayerMask mask;
    void LateUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 100, mask, QueryTriggerInteraction.Ignore))
        {
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
        } else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.green);
        }
    }
}
