using UnityEngine;
using UnityEngine.InputSystem;

public class Rotate : MonoBehaviour
{
    private string tag;
    public bool flip = true;
    public int Direction = 0;
    
    public string tg;
    public Transform Player;

    //Scripts
    public Square_Roate direction;

    public void Update()
    {
        
        //Getting a positive or negitive value for each keyboard press
        flop(ref flip);
        Convert(ref Direction, flip);

  
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        tg = collision.tag;

        switch(tg)
        {
            case "Right":
               
                if (flip == true)
                {
                    direction.up = true;
                   
                
                }
                else
                {
                    direction.up = false;

                }

                break;
            case "Down":
            if (flip == true && direction.up == true)
                {
                    direction.up = false;
                    flip = false;
                    break;
                }
            else 
                {
                    direction.up = !direction.up;

                    flip = !flip;

                }
                break;
            case "Up":
               if (flip == false && direction.up == false)
                {
                    flip = true;
                    direction.up = true;
                }
                else
                {
                    direction.up = false;
                    flip = true;
                }

                    break;
            case "Left":
                if (flip == false &&  direction.up == false)
                {
                    direction.up = true;
                    flip = false;
                }
                else
                {

                    direction.up = false;
                }
               break;

        }

        
        



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
