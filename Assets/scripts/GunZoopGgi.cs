using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunZoopGgi : MonoBehaviour
{
    GameObject nearObject;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Weapon"))
            nearObject = other.gameObject;
            Debug.Log(nearObject.name);
        Destroy(nearObject);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Weapon"))
            nearObject = null;
    }

}
