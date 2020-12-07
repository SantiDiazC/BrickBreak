using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.DestroyBrick();
        Destroy(gameObject);
    }
}
