using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEsqueleto : MonoBehaviour
{
    public GameObject golpePrefab;
    public float speed;
    public float jumpForce;
    public float recarga;
    public int vida;

    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private float horizontal;
    private bool grounded;
    private float lastShoot;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal < 0.0f) transform.localScale = new Vector3(-0.25f, 0.25f, 1.0f);
        else if (horizontal > 0.0f) transform.localScale = new Vector3(0.25f, 0.25f, 1.0f);

        animator.SetBool("Caminando", horizontal != 0.0f);


        Debug.DrawRay(transform.position, Vector3.down * 1.5f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 1.5f))
        {
            //animator.SetBool("Saltando", false);
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        animator.SetBool("Saltando", !grounded);

        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {

            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastShoot + recarga)
        {
            Shoot();
            lastShoot = Time.time;
        }
    }

    private void Jump()
    {
        animator.SetBool("Saltando", true);
        rigidbody2D.AddForce(Vector2.up * jumpForce);
    }

    private void Shoot()
    {
        animator.SetBool("Atacando", true);


    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(horizontal * speed, rigidbody2D.velocity.y);
    }

    public void DetenerAtaque()
    {
        animator.SetBool("Atacando", false);
        Vector3 direction;
        if (transform.localScale.x > 0) direction = Vector2.right;
        else direction = Vector2.left;
        GameObject hechizo = Instantiate(golpePrefab, transform.position + direction * 0.5f, Quaternion.identity);
        hechizo.GetComponent<GolpeScript>().setDirection(direction);

    }
}
