using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehavour : MonoBehaviour
{
    public float displacement = 5f;
    public float rotate = 60f;
    public Rigidbody2D rb;
    public float jumpHeight = 2f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, rotate);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(displacement * Time.deltaTime,0,0);
        transform.Rotate(0, 0, rotate * Time.deltaTime);
        transform.Translate(1, 0, 0);
    }
    void CustomTranslate(float a, float b, float c)
    {
        transform.position += new Vector3(a, b, c);
    }
    
}
