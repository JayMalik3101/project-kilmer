using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectBase : MonoBehaviour // de base effect class heeft alles voor de mogelijke effecten
{
    // de waardes die in de canvas gezet worden
    public Sprite effectImage;
    public string effectName;
    public GameObject car;

    // ik heb speciaal een enum gebruikt zodat je kan zien hoe dat ook werkt. als je meer info wilt msg me dan of kom ff langs
    [SerializeField] private EffectType type;
    [SerializeField] private float timer;
    // de timer en de active gedoe zijn voor de overtimeCast om te bepalen waneer er iets gecalled moet worden
    private bool active;
    private float maxTimer;

    private void Start()
    {
        maxTimer = timer;
    }

    private void Update()
    {
        if (active == true)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                OvertimeCastDeactivate();
            }
        }   
    }

    public void ActivateEffect()
    {
        //hier zie je hoe de enum gebruikt word en daaruit 1 van de 2 options gekozen word
        if(type == EffectType.instand)
        {
            InstandCast();
        }
        else if(type == EffectType.overTime)
        {
            timer = maxTimer;
            active = true;
            OvertimeCastActivate();
        }
    }

    public virtual void InstandCast()
    {

    } //de instand cast functie die je overschijft in je nieuwe effect script

    public virtual void OvertimeCastActivate()
    {

    } //de overcast cast functie die je overschijft in je nieuwe effect script
    public virtual void OvertimeCastDeactivate()
    {

    }
}

public enum EffectType //dit is hoe je een enum maakt (buiten de class)
{
    instand,
    overTime
};
