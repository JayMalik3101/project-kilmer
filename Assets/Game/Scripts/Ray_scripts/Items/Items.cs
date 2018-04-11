using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : Movement
{
    [SerializeField] private List<BaseEffects> EffectTypes = new List<BaseEffects>();
    

    private int counter = 2;



    // Use this for initialization
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item picked up");
        if (other.CompareTag("Player"))
        {
            Debug.Log("item chosen from list ");
            this.gameObject.SetActive(false);
            int r = Random.Range(0, EffectTypes.Count);
           
                Debug.Log("Geeft het door");
                other.GetComponent<Movement>().ActiveItem = EffectTypes[r];
        }
    }
}
