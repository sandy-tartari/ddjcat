using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catHero : MonoBehaviour
{
    // Start is called before the first frame update
     public float velocity;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log("O Maguin está na área!");
    }

    // Update is called once per frame
    void Update()
    {
        float inputKeyHorizontal = Input.GetAxis("Horizontal");
        float inputKeyVertical = Input.GetAxis("Vertical");
        float x = this.transform.position.x;
        float y = this.transform.position.y;

        if (inputKeyHorizontal > 0)
        {
            this.transform.position = new Vector2(x + this.velocity, y);
            this.spriteRenderer.flipX = false;
        }
        else if (inputKeyHorizontal < 0)
        {
            this.transform.position = new Vector2(x - this.velocity, y);
            this.spriteRenderer.flipX = true;
        }
    }

}
