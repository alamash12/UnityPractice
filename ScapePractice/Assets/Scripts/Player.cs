using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid;
    Collider2D coll;

    bool isJump = false;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isJump == false)
        {
            rigid.AddForce(Vector2.up * 15, ForceMode2D.Impulse);
            isJump = true;
            coll.isTrigger = true;
        }


    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Debug.Log(h);
        transform.Translate(Vector2.right * h * Time.deltaTime * 3);
    }
}
