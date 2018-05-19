using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AvoidEarlySoundRestart : MonoBehaviour
{
	// reference to AudioSource object
	// public - so assign in Inspector
	public AudioSource audioSource;

	// reference to UI Text object
	// public - so assign in Inspector
	public Text buttonText;

    //-------------------------------


    //----------------------------------
    // button click handler
    public void PlaySoundIfNotPlaying()
    {
        // only send Play() message to AudioSource object
        // if sound is NOT currently playing
        if (!audioSource.isActiveAndEnabled)
            audioSource.Pause();        
    }
}