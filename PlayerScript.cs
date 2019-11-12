using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left")) {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, this.transform.position, Quaternion.identity);
        }
    }
}
