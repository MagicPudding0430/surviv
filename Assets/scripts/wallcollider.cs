using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallcollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private SpriteRenderer spriteRenderer;

    private void Awake(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D bullet)
    {
        Destroy(bullet.gameObject);
    }


    }
