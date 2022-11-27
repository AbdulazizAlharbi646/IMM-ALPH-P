using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Bullet : MonoBehaviour
{
    Camera cam;
    [SerializeField]
    float speed = 15;

    public Vector3 currentPos { get; set; }

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
    }


}
