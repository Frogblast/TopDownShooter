using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 offset;
    private Vector3 rotationOffset;

    [SerializeField] private bool enableRotation;

    private void Awake()
    {
        offset = transform.position;
        rotationOffset = transform.rotation.eulerAngles;
    }

    private void Update()
    {
        transform.position = target.position + offset;
        if (enableRotation)
        {
            transform.rotation = Quaternion.Euler(target.rotation.eulerAngles + rotationOffset);
        }
    }
}
