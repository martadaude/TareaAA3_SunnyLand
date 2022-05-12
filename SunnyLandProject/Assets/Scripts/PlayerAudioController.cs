using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{


    bool isPlaying = false;

    // keep track of the jumping state ... 

    bool isJumping = false;


//declaro 

    float jumpPitch = 1.0f;

    float landPitch = 1.0f;


    // make sure to keep track of the movement as well !

    Rigidbody2D rb; // note the "2D" prefix 

//Declarar sonidos player


    public AudioSource audioSourceLand;
    public AudioSource audioSourceJump;
    public AudioSource audioSourceFootsteps;
    public AudioSource audioSourceCrouch;
    public AudioSource audioSourceCherry;
   
    


       
    
    // Start is called before the first frame update
    void Start()
    {
	

    rb = GetComponent<Rigidbody2D>();
	

    landPitch = 1.0f;

    jumpPitch = 1.0f;


    }



    // FixedUpdate is called whenever the physics engine updates
  
    void FixedUpdate()
    {


    float v = rb.velocity.magnitude;

    if (v > 1 && !isPlaying && !isJumping)
    {
	
	audioSourceFootsteps.Play();
	isPlaying = true;
	isJumping = false;
    }
    
    else if (v < 1 && isPlaying )
    {
    	audioSourceFootsteps.Stop();
	isPlaying = false;
    }

    else if (isJumping)
    {

	audioSourceFootsteps.Stop();
	isJumping = true;
     }

 }

    
    // trigger your LANDING sound here !



    public void OnLanding() {


    float randomNumber = Random.Range(1f, 50f);

    Debug.Log("Random Number of land is " + randomNumber);

    float randomModifier = Random.Range (1.1f, 2.0f);

    float finalPitch = landPitch * randomModifier;

	if (randomNumber < 50)
        {
	 audioSourceLand.pitch = finalPitch; 
 	}

    audioSourceLand.Play();

        isJumping = false;
        print("the fox has landed");
	




// to keep things cleaner, you might want to
// play this sound only when the fox actually jumped ...






    }

    // triggered FOOTSTEPS sound here

    public void OnFootsteps() {

    audioSourceFootsteps.Play();

    }




    // trigger your CROUCHING sound here

    public void OnCrouching() {

    audioSourceCrouch.Play();

        print("the fox is crouching");
    }
 



    // trigger your JUMPING sound here !

    public void OnJump() {


    float randomNumber = Random.Range(1f, 50f);

    Debug.Log("Random Number of jump is " + randomNumber);

    float randomModifier = Random.Range (1.1f, 2.0f);

    float finalPitch = jumpPitch * randomModifier;

	if (randomNumber < 50)
        {
	 audioSourceJump.pitch = finalPitch; 
 	}


    isJumping = true;
    print("the fox has jumped");
    audioSourceJump.Play();

    }




    // trigger your CHERRY collection sound here !
    public void OnCherryCollect() {

    audioSourceCherry.Play();

        print("the fox has collected a cherry");
    }


}
