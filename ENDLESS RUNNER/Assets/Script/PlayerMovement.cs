using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float kecepatan = 10;
    public float kanan = 5;
    public float jump = 50f;
    public Rigidbody rigidbody;
    public Animator anim;
    public Animation animate;
    public bool isGrounded = true;
    public int jumpcount = 0;
    public int maxjump = 1;
    

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        animate = GetComponent<Animation>();
    }

    

    void Update()
    {
       transform.Translate(Vector3.forward * Time.deltaTime * kecepatan, Space.World);
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x>LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * kanan);
            }
            
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if(this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * kanan * -1);
            }
            
        }

        if (Input.GetKey(KeyCode.Space)&&(isGrounded|| maxjump>jumpcount))
        {
            
            rigidbody.velocity = new Vector3(0, 8, 0);
            transform.Translate(rigidbody.velocity * Time.deltaTime );
            isGrounded = false;
            jumpcount++;
            
        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        jumpcount = 0;
    }

}
