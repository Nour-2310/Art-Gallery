using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioSource; // Drag your AudioSource here in the Inspector

    // This function can be called from a button or trigger
    public void PlayAudio()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
