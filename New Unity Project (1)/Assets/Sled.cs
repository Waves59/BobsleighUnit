using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sled : MonoBehaviour
{
    public float speed, maxSpeed = 100, rotation = 1f;

    Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(Vector3.up * rotation * Input.GetAxis("Horizontal") * Time.deltaTime);
        }

        anim.SetFloat("rotation", Input.GetAxis("Horizontal"));
    }
}
