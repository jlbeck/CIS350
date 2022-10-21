using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycast : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        RaycastHit hitInfo;

        //triggers if something is hit with ray
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);
        }

    }


}
