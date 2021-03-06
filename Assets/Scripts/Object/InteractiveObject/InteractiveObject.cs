using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class InteractiveObject : MonoBehaviour
{
    protected bool interactRetry = false;

    protected bool clearInteract = false;

    private bool interactable = false;

    public bool Interactable
    {
        get
        {
            return interactable;
        }
        set
        {
            interactable = value;
            OnInteractableChanged(value);
        }
    }

    public void OnMouseDown()
    {
        if (!Interactable ||
            EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        Interact();
    }

    protected virtual void OnInteractableChanged(bool value) { }

    protected abstract void Interact();
}
