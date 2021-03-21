using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catHero : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D body;
    private SpriteRenderer spriteRenderer;
    private bool jump;
    public float velocity;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    { 
        this.jump = false;
        this.body = this.GetComponent<Rigidbody2D>();
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log("O Maguin está na área!");
    }

    // Update is called once per frame
    void Update()
    {
        // Para frente e para trás
        float inputKeyHorizontal = Input.GetAxis("Horizontal");
        // Para cima e para baixo
        // float inputKeyVertical = Input.GetAxis("Vertical");
        if (inputKeyHorizontal > 0)
        {
            this.body.AddForce(new Vector2(this.velocity, 0));
            this.spriteRenderer.flipX = true;
        }
        else if (inputKeyHorizontal < 0)
        {
            this.body.AddForce(new Vector2(-this.velocity, 0));
            this.spriteRenderer.flipX = false;
        }
        if (Input.GetButton("Jump") && !this.jump)
        {
            this.jump = true;
            this.body.AddForce(new Vector2(0, this.jumpForce)); 
        }
        else if (this.body.velocity.y == 0 && this.jump )
        {
            this.jump = false;
        }
    }
}
