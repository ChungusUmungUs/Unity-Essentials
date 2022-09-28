using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 1;
    public float xVector = -1;
    public float yVector = 0;
    public float zVector = 0;
    public bool isMove = false;
    void Update()
    {
        if(isMove == true)
        {
            transform.position += new Vector3(xVector * speed, yVector * speed, zVector * speed);
        }
        
    }
}
