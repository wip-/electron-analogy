using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleConsumer : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
