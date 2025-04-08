using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public float addForce = 3f;
    public new Rigidbody2D rigidbody;
    public float moveDir;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveDir = 0;
        if (Input.GetKey(KeyCode.A)) moveDir = -1f; //왼쪽 움직임
        if (Input.GetKey(KeyCode.D)) moveDir = 1f; //오른쪽 움직임
        transform.position += new Vector3(moveDir, 0) * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.AddForce(Vector3.up * addForce, ForceMode2D.Impulse);

        if (collision.gameObject.CompareTag("Obstacle"))
            Debug.Log("GAME OVER");
    }
}
