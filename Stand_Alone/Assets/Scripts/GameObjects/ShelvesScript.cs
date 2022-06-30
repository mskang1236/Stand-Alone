using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelvesScript : MonoBehaviour
{

    // Main Camera ���� Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    public bool shelvesClicked = false;
    private bool hasInvestigated = false;

    // ������ ���� ��Ȳ
    public ItemScript Inventory;

    // Zoom-in ���� ��ġ
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {

        // Inventory �ҷ�����
        Inventory = GameObject.Find("Inventory").GetComponent<ItemScript>();

        // Main Camera �ҷ�����
        cameraPosition = GameObject.Find("Main Camera").GetComponent<Transform>();
        playerViewScript = GameObject.Find("Main Camera").GetComponent<PlayerView>();

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        shelvesClicked = true;

        // Ŭ�� �� ���εǴ� ���� ��ġ ����
        if (Inventory.hasChair == false) { zoomPosition = new Vector3(-22, 6, -40); }
        else { zoomPosition = new Vector3(-22, 20, -40); }
        zoomRotation = Quaternion.Euler(0, 270, 0);

        // Ŭ�� �� ����
        cameraPosition.position = zoomPosition;
        cameraPosition.rotation = zoomRotation;

        shelvesClicked = true;

        // ���ڰ� ���� ���
        if (Inventory.hasChair == false)
        {
            Debug.Log("������ �ʹ� ����.");
        }

        // ���ڸ� ���� 1�� ����
        else if (Inventory.hasChair == true && hasInvestigated == false)
        {
            Debug.Log("�̿� ���̿� ������ �̾߱�");
            hasInvestigated = true;
        }

        // ���ڸ� ���� 2�� ����
        else if (Inventory.hasChair == true && hasInvestigated == true && Inventory.hasDriver == false)
        {
            Debug.Log("���ݿ� ����̹��� �ִ�. �� ���� ���� �� ����.");
        }

        // ����̹� ȹ�� ��
        else if (Inventory.hasDriver == true)
        {
            Debug.Log("�� �̻� ������ ������ ���� ���δ�.");
        }
    }
}
