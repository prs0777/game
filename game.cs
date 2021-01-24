using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour
{
    float speed = 5.0f;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("right") == true)
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKey("left") == true)
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }
        void OnCollisionEnter(Collision col){

            if(col.gameObject.tag == "enemy")
            {
                Debug.Log("hit enemy");
                this.transform.localScale *= 0.5f;
                this.transform.position = new Vector3(0, 0, 0);

            }
            if(col.gameObject.tag == "goal")
            {
                Debug.Log("goal");
                this.transform.localScale *= 1.5f;
                this.transform.position = new Vector3(0, 0, 0);
            }
        }
}
