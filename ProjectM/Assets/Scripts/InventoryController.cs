using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject inventory;

    private bool isPopupOpen = false; // �˾� â�� �����ִ��� ���θ� ��Ÿ���� ����

    void Update()
    {
        // I Ű�� ������ �� �˾�
        if (Input.GetKeyDown(KeyCode.I))
        { 
            TogglePopup();
        }
    }

    // �˾� â�� ���ų� �ݴ� �Լ�
    void TogglePopup()
    {
        // �˾� â�� ���������� �ݰ�, �ƴϸ� ����.
        isPopupOpen = !isPopupOpen;
        inventory.SetActive(isPopupOpen);
    }
}
