using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    CameraMultipleTargets MultipleCam;

    private void Start()
    {
        MultipleCam = CameraMultipleTargets.FindObjectOfType<CameraMultipleTargets>();
    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            MultipleCam.RemoveCar(Player.gameObject);
            DestroyObject(Player.gameObject);
        }
    }
}
