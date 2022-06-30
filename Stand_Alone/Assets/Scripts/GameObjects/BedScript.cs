using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedScript : MonoBehaviour
{

    // Main Camera ���� Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // ħ�� ���ͷ���
    public bool foundDoll;
    public bool canGetBattery = false;
    public ItemScript Inventory;

    // Zoom-in ���� ��ġ
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {
        // ���� ��ġ ����
        zoomPosition = new Vector3(19, 6, 32);
        zoomRotation = Quaternion.Euler(57, 58, -7);

        // Main Camera �ҷ�����
        cameraPosition = GameObject.Find("Main Camera").GetComponent<Transform>();
        playerViewScript = GameObject.Find("Main Camera").GetComponent<PlayerView>();

        // Inventory �ҷ�����
        Inventory = GameObject.Find("Inventory").GetComponent<ItemScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        // Ŭ�� �� ����
        cameraPosition.position = zoomPosition;
        cameraPosition.rotation = zoomRotation;

        // ħ�븦 ó�� ������ ���
        if (foundDoll == false)
        {
            Debug.Log("������ ���� �ִ�.");
            foundDoll = true;
        }

        // ����̹��� ���� ���
        else if (foundDoll == true && Inventory.hasDriver == false)
        {
            Debug.Log("����̹��� �ʿ��ϴ�.");
        }

        // ����̹��� ���� ���
        else if (foundDoll == true && Inventory.hasDriver == true)
        {
            Debug.Log("���� �ȿ� �������� �ִ�.");
            canGetBattery = true;
        }
    }
}
