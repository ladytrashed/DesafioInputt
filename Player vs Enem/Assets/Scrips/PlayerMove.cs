using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3f;
    public GameObject munition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
           MovePLayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePLayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePLayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovePLayer(Vector3.right);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Shoot();
        }
     }
      private void MovePLayer(Vector3 dir)
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void Shoot()
    {
        Debug.Log("DISPARAR");
        Instantiate(munition, transform.position, munition.transform.rotation);
    }
}
