﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Bullet : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private Collider myCollider;

    // Start is called before the first frame update
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        if (myRigidbody != null)
        {
            Invoke("AutoDestroy", 10F);

            myCollider = GetComponent<Collider>();

            if (myCollider != null)
            {
                myCollider.isTrigger = false;
            }
        }
        else
        {
            AutoDestroy();
        }
    }

    private void AutoDestroy()
    {
        Destroy(gameObject);
    }
}