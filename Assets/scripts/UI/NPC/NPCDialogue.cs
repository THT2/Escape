using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public string dialogText = "Hello, this is the dialog text.";
    public TextMeshProUGUI textComponent;
    public GameObject dialogPanel;
    public string tag;

    void Start()
    {
        dialogPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag(tag))
                {
                    StartDialog(true);
                }
                else if (!hit.collider.CompareTag(tag))
                {
                    StartDialog(false);
                }
            }
        }
    }

    void StartDialog(bool status)
    {
        textComponent.text = dialogText;

        dialogPanel.SetActive(status);
    }
}
