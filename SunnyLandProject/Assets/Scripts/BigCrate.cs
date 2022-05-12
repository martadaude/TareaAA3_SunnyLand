using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCrate : MonoBehaviour
{
	
//Declaramos los audiosources para la big crate

    public AudioSource audioSourceWoodImpact;
    public AudioSource audioSourceWoodRumble;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {


//Indicamos que cuando haya collision, se reproduzcan los sonidos

    audioSourceWoodImpact.Play();
    audioSourceWoodRumble.Play();

    }

}
