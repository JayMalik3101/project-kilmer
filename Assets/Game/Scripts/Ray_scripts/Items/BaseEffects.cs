using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEffects : MonoBehaviour
{
    public enum PickupType
    {
        Boost,
        missile

    }

    public PickupType ItemType;

    [SerializeField] private string Name;
   
    

}
