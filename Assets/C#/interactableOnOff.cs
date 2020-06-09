using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactableOnOff : MonoBehaviour
{
    public Button interactableButton, interactableButton1, interactableButton2, interactableButton3, interactableButton4;

    public void setInteractable()
    {
        interactableButton.interactable = !interactableButton.interactable;
        interactableButton1.interactable = !interactableButton1.interactable;
        interactableButton2.interactable = !interactableButton2.interactable;
        interactableButton3.interactable = !interactableButton3.interactable;
        interactableButton4.interactable = !interactableButton4.interactable;

    }
}
