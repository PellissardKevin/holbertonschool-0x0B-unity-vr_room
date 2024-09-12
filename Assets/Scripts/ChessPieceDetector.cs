using UnityEngine;

public class ChessPieceDetector : MonoBehaviour
{
    public AudioSource activationSound;
    public Material successMaterial;
    [SerializeField]
    private ProjectorManager _projectorManager;

    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag.Equals("Projector1"))
        {
            _projectorManager.IsProjector1Enabled = true;
            collider.gameObject.GetComponent<MeshRenderer>().material = successMaterial;
            activationSound.Play();
        }
    }
}
