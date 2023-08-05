using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyDelay = 0.2f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 dontHasPackageColor = new Color32(2, 2, 2, 1);
    public SpriteRenderer spriteRenderer;
    /*void Start()
    {
        spriteRenderer = GetComponent < SpriteRenderer> ();
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        
        if (collision.tag == "package") {
            Debug.Log("Package just picked up !!! ");
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }
        

        if (collision.tag == "custumer"&&hasPackage==true)
        {
            Debug.Log("Package just deliveried");
            hasPackage = false;
            spriteRenderer.color = dontHasPackageColor;
        }

    }
    

}
