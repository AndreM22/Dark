using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemScript : MonoBehaviour
{
    private Animator animator;
    private EnemigosRecibirDaño enemigosRecibirDaño;
    private CapsuleCollider2D colliderVivo;
    private BoxCollider2D colliderMuerto;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        enemigosRecibirDaño = GetComponent<EnemigosRecibirDaño>();
        colliderVivo = GetComponent<CapsuleCollider2D>();
        colliderMuerto = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemigosRecibirDaño.vida<=0)
        {
            animator.SetBool("Muriendo", true);
            colliderVivo.enabled = false;
            colliderMuerto.enabled = true;
        }
    }

    public void morir()
    {
        Destroy(this.gameObject, 1f);
    }
}
