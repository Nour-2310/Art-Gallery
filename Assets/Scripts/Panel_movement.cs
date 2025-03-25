using UnityEngine;

public class  print : MonoBehaviour
{
    public GameObject uiPanel; // Assign UI Panel in Inspector

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPanel.SetActive(true);
            Debug.Log("Triggered");
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPanel.SetActive(false);
        }
    }
}