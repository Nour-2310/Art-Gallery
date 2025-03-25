using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightRemoteController : MonoBehaviour
{
    [SerializeField] private  List<Light> linkedLights;
    [SerializeField] private AudioSource audioSource; 
    private XRGrabInteractable grabInteractable;

    public void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener((_) => StartPress());
    }

    public void StartPress()
    {
        for (int i = 0; i < linkedLights.Count; i++){
            linkedLights[i].enabled = !linkedLights[i].enabled;
        }

        if (audioSource != null)
        {
            audioSource.Play(); 
        }
    }
}