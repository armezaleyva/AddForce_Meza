using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPhysics : MonoBehaviour
{
    Rigidbody2D rigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.AddForce(Vector2.up * 500, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
