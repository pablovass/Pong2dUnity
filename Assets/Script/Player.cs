using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

       // transform.position = new Vector3(transform.position.x,mousePos.y,transform.position.z );
       transform.position = new Vector3(transform.position.x,Mathf.Clamp(mousePos.y,-2.22f,2.22f),transform.position.z );
    }
}
