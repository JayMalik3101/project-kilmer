using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // dingen voor de item 
    [SerializeField] private Box box;
    [HideInInspector]
    public BaseEffects ActiveItem;
    private float m_timer = 10;
    public string Player;
    public string m_item_activate_key;
    public GameObject Rocket;
    
    public Transform rocketlaunch_origin;

    [SerializeField] int RotationSpeed;
    [SerializeField] float Speed;
    //private 
    bool isBoosted;
    float TargetSpeed = 6;
    bool missleshot;
    

    int x = 0;
    int z = 0;


    public Vector3 userDirection = Vector3.right;

    public void Start()
    {
        TargetSpeed = Speed;
    }

    public void Update()
    {
        m_timer += 1 * Time.deltaTime;
        transform.Translate(userDirection * Speed * Time.deltaTime);

        float x = Input.GetAxis(Player) * Time.deltaTime * RotationSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        // de speedboost word uitgevoerd als hij gekozen is uit de list 
        if (ActiveItem != null && Input.GetKeyDown(m_item_activate_key))
        {
            Debug.Log("item speedboost is gekozen");
            switch (ActiveItem.ItemType)
            {
                case BaseEffects.PickupType.Boost:
                    {
                        isBoosted = true;
                        m_timer = 0;
                        Debug.Log("Boost");
                        break;
                    }
                    
                case BaseEffects.PickupType.missile:
                    {
                        ;
                        Debug.Log("missile gepakt");
                       
                        
                        missleshot = true;
                        
                    }

                    break;
                     

                    

            }
            ActiveItem = null;
        }
         




        if (isBoosted == true)
        {
            // jouw boost code
            if (m_timer <= 0.5f)
            {
                Speed = 12;
                Speed -= 1;

            }
            else
            {

                isBoosted = false;
                Speed = 6;

            }
            

        }
        if (missleshot == true)
        {

            GameObject Rocketprefab = Instantiate(Rocket, rocketlaunch_origin.position, rocketlaunch_origin.localRotation);
            Rigidbody rb = Rocketprefab.GetComponent<Rigidbody>();
            rb.AddForce(rocketlaunch_origin.forward * 0, ForceMode.VelocityChange);
            missleshot = false; 
            // 







        }


    }
}
