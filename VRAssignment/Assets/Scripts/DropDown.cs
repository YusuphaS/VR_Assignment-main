using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class DropDown : MonoBehaviour
{
    [SerializeField] private ActionBasedSnapTurnProvider snapTurn;
    [SerializeField] private ActionBasedContinuousTurnProvider continuousTurn;
    [SerializeField] public Transform head;
    [SerializeField] public float spawnDistance = 2f;
    [SerializeField] public GameObject menu;
    [SerializeField] public InputActionProperty showButton;
    public void TurnProviderSelect(int index)
    {
        if (index == 0)
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }
        if (index == 1)
        {
            continuousTurn.enabled = true;
            snapTurn.enabled = false;
        }
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);

            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;
    }
}
