using UnityEngine;

public class StatueDetector : MonoBehaviour
{
    public AudioSource activationSound;
    public Material successMaterial;
    [SerializeField]
    private ProjectorManager _projectorManager;

    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag.Equals("Projector2"))
        {
            _projectorManager.IsProjector2Enabled = true;
            collider.gameObject.GetComponent<MeshRenderer>().material = successMaterial;
            activationSound.Play();
        }
    }
}
