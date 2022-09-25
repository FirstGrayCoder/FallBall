using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScaleScript : MonoBehaviour
{
    public static GravityScaleScript link;
    public Rigidbody2D rbPlatform;
    // Start is called before the first frame update
    void Start()
    {
        //link = this;
        rbPlatform.gravityScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
