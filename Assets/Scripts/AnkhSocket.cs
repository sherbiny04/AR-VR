using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnkhSocket : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;
    public Animator treasureAnimator;
    bool isTreasureOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable object1 = socket.GetOldestInteractableSelected();

        if (object1 != null)
        {
            if (object1.transform.name == "Ankh")
            {
                if (!isTreasureOpen)
                {
                    treasureAnimator.SetTrigger("OpenTreasure");
                    isTreasureOpen = true;
                }
            }

        }
    }
}
