using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10;

	// initialization
	void Start ()
    {
		rb = GetComponent<Rigidbody>();
	}
	
    // update for physics simulation
    void FixedUpdate()
    {
        // make particles rotate around the center
        Vector3 originToParticle = transform.position;
        originToParticle.y = 0; // do not move along vertical Y axis
        Vector3 trajectoryTangent = Vector3.Cross(originToParticle, Vector3.up).normalized;
        rb.MovePosition(transform.position + trajectoryTangent * speed * Time.deltaTime);
    }
}
