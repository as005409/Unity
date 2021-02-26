using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log(gameObject.name);
    }
}
