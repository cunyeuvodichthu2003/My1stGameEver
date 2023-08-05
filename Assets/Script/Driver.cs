using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float movespeed=0.01f;
    [SerializeField] float steerspeed=0.1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0,0,steerspeed);
        
        transform.Translate(0,movespeed,0);
    }
}
