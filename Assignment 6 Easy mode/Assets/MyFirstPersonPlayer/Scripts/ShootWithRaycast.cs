/*
 * Josh Beck
 * Assignment 5B
 * Controls shooting and determines whether a target was successfully hit
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycast : MonoBehaviour
{
    public int damage = 10;
    public float range = 100f;
    public Camera cam;

    public ParticleSystem muzzleFlash;

    public float hitForce = 10f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {

        muzzleFlash.Play();

        RaycastHit hitInfo;

        //triggers if something is hit with ray
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            Target target = hitInfo.transform.gameObject.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }

            //If shot hits a RigidBody, apply a force
            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }

        }

    }


}
