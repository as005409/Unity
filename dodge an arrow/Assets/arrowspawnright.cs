﻿using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class arrowspawnleft : MonoBehaviour
{
    public GameObject[] arrowsr;

    public float delayTimer1 = 2f;
    float timer;

    int position;
    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer1;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 pos = new Vector3();
            position = Random.Range(1, 4);
            switch (position)
            {
                case 1:
                    pos = new Vector3(12.13f, 2.93f, 0);
                    break;
                case 2:
                    pos = new Vector3(12.13f, 0.97f, 0);
                    break;
                case 3:
                    pos = new Vector3(12.13f, -1.07f, 0);
                    break;
            }
            Instantiate(arrowsr[0], pos, transform.rotation);
            timer = delayTimer1;

        }
    }
}