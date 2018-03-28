using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private List<EffectBase> mogelijkeEffecten = new List<EffectBase>();

    public EffectBase GetEffect()
    {
        int r = Random.Range(0, mogelijkeEffecten.Count);
        return mogelijkeEffecten[r];
    }
}
