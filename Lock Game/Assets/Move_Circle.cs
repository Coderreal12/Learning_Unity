using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Move_Circle : MonoBehaviour
{
    public bool load = true;
    


    private int side = 1;
    private bool flip = true;
    public Transform middle;
    [SerializeField] public float speed = 25;
    void Update()
    {
        flop(ref side, ref flip);
        transform.RotateAround(middle.position, new Vector3(0, 0,  1 * side), speed * Time.deltaTime);







    }

    void flop(ref int side, ref bool flip)
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            flip = !flip;
        }

        switch(flip)
        {
            case true:
                side = 1;

                break;

            case false:
                side = -1;
                break;
        }
        
    }




}
