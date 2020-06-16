using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody rb;
    private Animator anim;
    public float speed;
    public float rotationSpeed;

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float rotation = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;

        transform.Translate(0f, 0f, translation);
        transform.Rotate(0f, rotation, 0f);

        if (translation > 0f)
        {
            anim.SetBool("isMoving", true);
            anim.SetFloat("isMovingBackwards", 1f);
        }
        else if (translation < 0f)
        {
            anim.SetBool("isMoving", true);
            anim.SetFloat("isMovingBackwards", -1f);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
    }
}
