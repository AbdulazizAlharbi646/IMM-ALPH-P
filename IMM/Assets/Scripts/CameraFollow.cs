using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target = null;

    private Vector3 offset;
    float startY;

    // Start is called before the first frame update
    void Start()
    {
        startY = target.position.y;
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        float yDiff = target.position.y - startY;
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, yDiff, target.position.z) + offset, Time.deltaTime * 3);
    }
}
