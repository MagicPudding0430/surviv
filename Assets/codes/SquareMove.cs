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
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    
        if (Input.GetKey(KeyCode.W)) transform.position = transform.position + transform.up * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.S)) transform.position = transform.position - transform.up * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.A)) transform.position = transform.position - transform.right * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.D)) transform.position = transform.position + transform.right * Time.deltaTime * speed;
    }
}
