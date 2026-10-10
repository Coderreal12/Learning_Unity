using System;
using UnityEngine;

public class Square_Roate : MonoBehaviour
{
    //Variables
    public bool up = true;

    public bool rotation = true;

    public float speed;

    public float negspeed;

    public float posspeed;

    //Scripts
    public Rotate rotate;



    private void Start()
    {
        up = true;

        negspeed = speed * -1;

        posspeed = speed;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void FixedUpdate()
    {
        rotation = rotate.flip; 



        if (rotation)
        {
           speed = posspeed; 
        }
        else
        {

speed = negspeed;
            
        }




        
        if (up)
        {
            transform.localPosition += new Vector3(1 * speed, 0, 0);
        }
        else
        {
            transform.localPosition += new Vector3(0, 1 * speed, 0);
        }
        
    }
}
