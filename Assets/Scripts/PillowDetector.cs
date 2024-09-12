using UnityEngine;

public class PillowDetector : MonoBehaviour
{
    public AudioSource activationSound;
    public Material successMaterial;
    [SerializeField]
    private ProjectorManager _projectorManager;

    public void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag.Equals("Projector4"))
        {
            _projectorManager.IsProjector4Enabled = true;

            foreach (MeshRenderer renderer in collider.gameObject.GetComponentsInChildren<MeshRenderer>())
                renderer.material = successMaterial;

            activationSound.Play();
        }
    }
}
