using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    [SerializeField] private Box box; //deze heb jij niet. dit is de onTriggerEnter(other object)

    #region canvasGedoe //hierin zitten de canvas elementen. dit is niet belangrijk

    [SerializeField] private Text currentEffect;
    [SerializeField] private Image effectImage;

    #endregion  

    public float speed;//speed is er alleen maar voor het idee

    private EffectBase effect;
    
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //in jouw situatie zou dit niet handmatig gebeuren. maar op het moment dat de auto de box raakt met de onTriggerEnter()
        {
            effect = box.GetEffect(); //pak een willekeurig effect uit de box

            //zet alle canvas elementen
            effectImage.sprite = effect.effectImage;
            currentEffect.text = effect.effectName;

            effect.car = gameObject; //zet dit gameobject als de auto voor het effect
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (effect != null)
                effect.ActivateEffect(); // activeer het effect als er 1 bestaat

            //reset effect nadat hij gebruikt is;
            effect = null;
            currentEffect.text = "";
            effectImage.sprite = null;
        }
	}
}
