using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private float Speed;
    private float currenSpeed;

    private Rigidbody2D rb;
    private Animator ani;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        currenSpeed = Speed;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 || vertical != 0)
        {

            if (currenSpeed < 10)
            {
                currenSpeed += Time.deltaTime;
            }
        }
        else
        {
            currenSpeed = Speed;
        }
        rb.velocity = new Vector3(horizontal, vertical, 0).normalized * currenSpeed;
        ani.SetFloat("inputX", horizontal);
        ani.SetFloat("inputY", vertical);
    }


}
