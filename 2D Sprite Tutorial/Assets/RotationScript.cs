using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public Rigidbody2D BallRigid;
    private float randomSpin;
    public bool rotateTrue = true;
    // Start is called before the first frame update
    void Start()
    {
        randomSpin = Random.Range(-2000,2000);
        BallRigid = GetComponent<Rigidbody2D>();
        while(randomSpin < 200 && randomSpin > -200)
        {
            randomSpin = Random.Range(-200, 200);
        }
        BallRigid.angularVelocity = randomSpin;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
