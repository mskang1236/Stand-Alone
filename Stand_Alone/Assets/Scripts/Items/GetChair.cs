using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChair : MonoBehaviour
{

    // Main Camera ���� Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // bool
    public bool chairClicked = false;

    // ������ �κ��丮
    public ItemScript Inventory;

    // Zoom-in ���� ��ġ
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {
        // Ŭ�� �� ���εǴ� ���� ��ġ ����
        zoomPosition = new Vector3(-6, 19, -20);
        zoomRotation = Quaternion.Euler(10, 258, 0);

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

        Inventory.hasChair = true;
        chairClicked = true;
    }
}
