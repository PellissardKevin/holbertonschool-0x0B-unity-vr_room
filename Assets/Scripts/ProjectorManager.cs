using System.ComponentModel;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ProjectorManager : MonoBehaviour
{
    public AudioSource activationSound;
    [SerializeField]
    private XRSimpleInteractable _projector;

    [DefaultValue(false)]
    public bool IsProjector1Enabled { get; set; }
    [DefaultValue(false)]
    public bool IsProjector2Enabled { get; set; }
    [DefaultValue(false)]
    public bool IsProjector3Enabled { get; set; }
    [DefaultValue(false)]
    public bool IsProjector4Enabled { get; set; }


    private void Update()
    {
        if (IsProjector1Enabled &&  IsProjector2Enabled && IsProjector3Enabled && IsProjector4Enabled)
        {
            _projector.enabled = true;
            activationSound.Play();
        }
    }
}
