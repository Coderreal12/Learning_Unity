using UnityEngine;

public class Spawn_random : MonoBehaviour
{
    private void Awake()
    {
        int quad = Random.Range(1,5);


        switch(quad)
        {
            case 1:
 transform.position = new Vector3(-3, Random.Range(2.69f, -2.82f), 0);
                break;
            case 2:
                transform.position = new Vector3(Random.Range(-3f, 3.08f),-3.66f , 0);
                break;
            case 3:
                transform.position = new Vector3(3.08f, Random.Range(-3.66f, 2.38f), 0);
                break;
            case 4:
                transform.position = new Vector3(Random.Range(-2.9f, 2.93f), 2.38f,0);
                break;
        }    
       
    }
}
