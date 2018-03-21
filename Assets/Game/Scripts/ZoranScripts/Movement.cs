using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public string Player;

    [SerializeField] int RotationSpeed;
    [SerializeField] int Speed;

    int x = 0;
    int z = 0;

    public Vector3 userDirection = Vector3.right;

    public void Start()
    {

    }

    public void Update()
    {
        transform.Translate(userDirection * Speed * Time.deltaTime);

        float x = Input.GetAxis(Player) * Time.deltaTime * RotationSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
