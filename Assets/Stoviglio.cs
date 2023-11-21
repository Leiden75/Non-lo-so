using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stoviglio : MonoBehaviour
{
    public Rigidbody2D rb;
    float forzaSalto = 500f;
    bool OnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); 
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnGround)
        {
            // Applica una forza verso l'alto al Rigidbody per farlo saltare
            rb.AddForce(Vector3.up * forzaSalto);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        {
           OnGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        {
            OnGround = false;
        }
    }
}
