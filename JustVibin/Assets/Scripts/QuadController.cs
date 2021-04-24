using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadController : MonoBehaviour
{
    Renderer rend;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.mainTextureOffset += new Vector2(0, Time.deltaTime * speed);
    }
}
