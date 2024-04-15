using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject inventory;

    private bool isPopupOpen = false; // 팝업 창이 열려있는지 여부를 나타내는 변수

    void Update()
    {
        // I 키를 눌렀을 때 팝업
        if (Input.GetKeyDown(KeyCode.I))
        { 
            TogglePopup();
        }
    }

    // 팝업 창을 열거나 닫는 함수
    void TogglePopup()
    {
        // 팝업 창이 열려있으면 닫고, 아니면 열림.
        isPopupOpen = !isPopupOpen;
        inventory.SetActive(isPopupOpen);
    }
}
