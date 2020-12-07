using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChange : MonoBehaviour
{

    public Texture FirstTexture;
    public Texture SecondTexture;
    public Texture ThirdTexture;

  
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            GetComponent<Renderer>().material.SetTexture("_MainTex", FirstTexture);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            GetComponent<Renderer>().material.SetTexture("_MainTex", SecondTexture);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            GetComponent<Renderer>().material.SetTexture("_MainTex", ThirdTexture);
    }
}
