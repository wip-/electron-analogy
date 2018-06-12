using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEmitter : MonoBehaviour
{
    public Transform particleTemplate;
    public int emissionRate = 1;
	
    // update for physics simulation
	void FixedUpdate ()
    {
        for(int i = 0; i<emissionRate; ++i)
        {
            Vector3 position;
            position.x = -2.6f;
            position.y = Random.Range(0.4f, 1.4f);
            position.z = Random.Range(7.4f, 9.4f);
            Instantiate(particleTemplate, position, Quaternion.identity);
        }
	}
}
