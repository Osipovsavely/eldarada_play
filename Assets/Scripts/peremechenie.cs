using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peremechenie : MonoBehaviour
{
    [SerializeField]int x1;
    [SerializeField]int x2;
    [SerializeField]int z1;
    [SerializeField]int z2;
    [SerializeField]Rigidbody rb;
    //[SerializeField] float movementSpeed = 5f;
    //float currentSpeed;
    //Vector3 direction;


    //void Start()
   // {        
   //     rb = GetComponent<Rigidbody>();
   //    currentSpeed = movementSpeed;
   // }

   // void Update()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");
   //     float moveVertical = Input.GetAxis("Vertical");
   //     direction = new Vector3(moveHorizontal, 0.0f, moveVertical);
   //     direction = transform.TransformDirection(direction);
//
    //    if 
    //}
    //void FixedUpdate()
    //{
    //    rb.MovePosition(transform.position + direction * currentSpeed * Time.deltaTime);
    //}

    //int x1_c = 300;
    //int x2_c = 500;
    //int z1_c = -500;
    //int z2_c = -300;
 
    void Update()
    //void ee()
    {
        
        
        //if (Input.GetKeyDown(KeyCode.W) && transform.position.x > x1 && transform.position.x < x2)
        //{
            //rb.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime); 
            //transform.Translate(-9, 0, 0);

        //}
        if (Input.GetKeyDown(KeyCode.S) && transform.position.x > x1 && transform.position.x < x2)
        {
            //rb.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime); 
            
            rb.AddForce (transform.forward*100*Time.deltaTime);
              
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > z1 && transform.position.x < z2)
        {
            rb.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime); 

        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x > z1 && transform.position.x < z2)
        {
            rb.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime); 

        }

        
    }
//{
//    rb.MovePosition(transform.position + transform.forward * speed * Time.fixedDeltaTime); 
//}
}
