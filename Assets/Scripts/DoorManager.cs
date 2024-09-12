using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public Animator anim;
    public AudioSource doorSound;
    public GameObject instructionCanvas;

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals("Door") && instructionCanvas.activeSelf)
        {
            anim.SetBool("character_nearby", true);
            doorSound.Play();
        }
    }
}
