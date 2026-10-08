using UnityEngine;

public class Rotate_around : MonoBehaviour
{
    [SerializeField] public Transform orbit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
      
        transform.RotateAround(orbit.position, new Vector3(0, 0, 1), Random.Range(0, 360));
    }
}
