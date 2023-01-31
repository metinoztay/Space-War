using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D myrigidbody2D = GetComponent<Rigidbody2D>();
        myrigidbody2D.AddForce(new Vector2(5,5),ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kemerlerinizi Baglayin!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
