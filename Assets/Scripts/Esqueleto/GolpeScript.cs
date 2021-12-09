using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolpeScript : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rigidbody2D;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        DestroyGolpe();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rigidbody2D.velocity = direction * Speed;
    }

    public void setDirection(Vector2 d)
    {
        direction = d;
        if(d.x>0f) transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        else transform.localScale = new Vector3(-0.25f, 0.25f, 0.25f);
    }

    public void DestroyGolpe()
    {
        Destroy(gameObject, 0.25f);
    }
}
