using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class me : MonoBehaviour
{
    private float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        if (Input.GetKey(KeyCode.W)) transform.position = transform.position + transform.up * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.S)) transform.position = transform.position - transform.up * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.A)) transform.position = transform.position - transform.right * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.D)) transform.position = transform.position + transform.right * Time.deltaTime * speed;
=======
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Move(x)
        Move(y)
>>>>>>> Stashed changes
    }
}
