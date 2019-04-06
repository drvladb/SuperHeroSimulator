using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
    float distToGround;
    public GameObject bullet;
    float BulletDelay;
    private Rigidbody rb;
    public 
    // Start is called before the first frame update
    void Start()
    { 
        distToGround = this.GetComponent<Collider>().bounds.extents.y;
        rb = this.GetComponent<Rigidbody>();
        BulletDelay = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(rb.velocity.magnitude);
        if (Input.GetKey(KeyCode.W))
        {
            if (rb.velocity.magnitude < 10)
            {
                //rb.AddForce(new Vector3(0, -18, 0));
                this.gameObject.transform.position += this.gameObject.transform.forward * 1;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (rb.velocity.magnitude < 10)
            {
                //rb.AddForce(new Vector3(0, -18, 0));
                this.gameObject.transform.position +=this.gameObject.transform.right * -1;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (rb.velocity.magnitude < 10)
            {
                //rb.AddForce(new Vector3(0, -18, 0));
                this.gameObject.transform.position += this.gameObject.transform.forward * -1;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (rb.velocity.magnitude < 10)
            {
                //rb.AddForce(new Vector3(0, -18, 0));
                this.gameObject.transform.position +=  this.gameObject.transform.right * 1;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
            {
                if (rb.velocity.magnitude < 10)
                {
                //rb.AddForce(new Vector3(0, 18, 0));
                this.gameObject.transform.position += new Vector3(0, 0.1f, 0);
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (rb.velocity.magnitude < 10)
                {
                //rb.AddForce(new Vector3(0, -18, 0));
                this.gameObject.transform.position += new Vector3(0, -0.1f, 0);
                }
            }
        
        if (Input.GetKey(KeyCode.E))
            {
                if (BulletDelay >= 60f)
                {
                    GameObject bullet1 = Instantiate(bullet.transform.GetChild(0).gameObject, this.transform.position + Vector3.up * 2.5f + this.transform.forward * -3, Quaternion.identity);
                    bullet1.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -1f) * -750);
                    Destroy(bullet1.gameObject, 3);
                    BulletDelay = 0;
                }
            }

            BulletDelay++;
        }
}
