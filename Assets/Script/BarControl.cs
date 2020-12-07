using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarControl : MonoBehaviour
{
    public float BarSpeed = 0.1f;
    public Vector3 NewPos = new Vector3(3.5f, 6.5f, 0.15f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * BarSpeed);

        NewPos = new Vector3(Mathf.Clamp(xPos, -2.1f, 8.0f), 6.5f, 0.15f);
        transform.position = NewPos;

       
    }
}
