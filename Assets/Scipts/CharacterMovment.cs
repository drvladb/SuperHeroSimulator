using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
    float distToGround;
    public GameObject bullet;
    float BulletDelay;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    { 
        distToGround = this.GetComponent<Collider>().bounds.extents.y;
        rb = this.GetComponent<Rigidbody>();
        BulletDelay = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb.velocity.magnitude);
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (rb.velocity.magnitude < 10)
                {
                    rb.AddForce(new Vector3(0, 18, 0));
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (rb.velocity.magnitude < 10)
                {
                    rb.AddForce(new Vector3(0, -18, 0));
                }
            }
            if (Input.GetKey(KeyCode.S))
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
