using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 212 : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody=GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float moveX
         if(Input.GetKeyDown(KeyCode.Space)){
             Debug.Log("Space")
         }
    }
}
