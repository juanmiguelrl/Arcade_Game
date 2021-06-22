using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iniciarobstaculoangulo : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      int rotation = Random.Range(1,6);
        rb.rotation = 60 *rotation;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
