using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody bulletRB;
    [SerializeField]
    private float _bulletSpeed = 600.0f;

    private void Awake()
    {
        bulletRB = this.GetComponent<Rigidbody>();
        Debug.Log("I'm the bullet and I'm alive now!");

        Destroy(this.gameObject, 2.0f);
    }

    private void FixedUpdate()
    {
        bulletRB.velocity = transform.forward * _bulletSpeed * Time.fixedDeltaTime;
    }
}
