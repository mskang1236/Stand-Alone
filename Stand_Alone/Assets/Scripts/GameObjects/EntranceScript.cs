using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceScript : MonoBehaviour
{
    // Main Camera ���� Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // ������ ���� ��Ȳ
    public ItemScript Inventory;

    // Zoom-in ���� ��ġ
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // ���� ���� ����
    public bool gameClear = false;

    // Start is called before the first frame update
    void Start()
    {

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
        // Ŭ�� �� ���εǴ� ���� ��ġ ����
        if (Inventory.hasChair == false) { zoomPosition = new Vector3(-33, 6, 55); }
        else { zoomPosition = new Vector3(-33, 20, 55); }
        zoomRotation = Quaternion.Euler(0, 0, 0);

        // Ŭ�� �� ����
        cameraPosition.rotation = zoomRotation;
        cameraPosition.position = zoomPosition;

        // ���ڰ� ���� ���
        if (Inventory.hasChair == false)
        {
            Debug.Log("Ű�� ���� �ʴ´�.");
        }

        // ���ڴ� ������, ����̹��� ������ ��� ���� ���
        else if (Inventory.hasDriver == false && (Inventory.hasClockBattery == false && Inventory.hasDollBattery == false))
        {
            Debug.Log("���� ������ �ʴ´�.");
        }

        // ����̹��� ������, �������� ���� ���
        else if (Inventory.hasDriver == false && Inventory.hasAllBatteries == true)
        {
            Debug.Log("���� �� �� �ִ� ������ �ʿ��ϴ�.");
        }

        // ����̹��� ������ �������� ���� ���
        else if (Inventory.hasDriver == true && Inventory.hasClockBattery == false && Inventory.hasDollBattery == false)
        {
            Debug.Log("������� ���͸��� ����.");
        }

        // ����̹��� ������, ������ ������ ������ ���
        else if (Inventory.hasDriver == true && (Inventory.hasClockBattery == true || Inventory.hasDollBattery == true) && Inventory.hasAllBatteries == false)
        {
            Debug.Log("�������� �����ϴ�.");
        }

        // ����̹��� �ְ�, ��� �������� ���� ���� ���
        else if (Inventory.hasDriver == true && Inventory.hasAllBatteries == true)
        {
            Debug.Log("���� ����");
            gameClear = true;
        }
    }
}
