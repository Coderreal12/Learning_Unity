using UnityEngine;
using UnityEngine.InputSystem;

public class Rotate : MonoBehaviour
{
    private string tag;
    public bool flip = true;
    public int Direction = 0;
    public float speed = 5;

    public Transform Player;
    public void Update()
    {
        
        //Getting a positive or negitive value for each keyboard press
        flop(ref flip);
        Convert(ref Direction, flip);

      Player.Translate( Direction *  speed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Player.rotation =  Quaternion.Euler(0, 0, transform.eulerAngles.z +  90);
        



    }




    //functions
    public static void  flop(ref bool flip)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
 flip = !flip;
        }
           
    }

    public static void Convert(ref int Direction, bool flip)
    {
        switch(flip)
        {
            case true:
                Direction = 1;
                break;
            case false:
                Direction = -1;
                break;

        }
    }

}
