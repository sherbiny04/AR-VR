using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SocketObject : MonoBehaviour
{

    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket1;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket2;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket3;

    public Animator coffinAnimator;
    public AudioSource coffinAudio;

    bool isCoffinOpen = false;

    void Start()
    {
    }

    void Update()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable object1 = socket1.hasSelection ? socket1.firstInteractableSelected : null;
        UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable object2 = socket2.hasSelection ? socket2.firstInteractableSelected : null;
        UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable object3 = socket3.hasSelection ? socket3.firstInteractableSelected : null;

        if (object1 != null && object2 != null && object3 != null)
        {

            if (object1.transform.name == "Pyramid" && object2.transform.name == "MagicBox" && object3.transform.name == "Scarab")
            {
                if (!isCoffinOpen)
                {
                    coffinAnimator.SetTrigger("OpenCoffin");
                    coffinAudio.Play();
                    isCoffinOpen = true;
                }
            }
        }
    }

}
