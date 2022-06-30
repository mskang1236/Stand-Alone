using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChair : MonoBehaviour
{

    // Main Camera 관련 Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // bool
    public bool chairClicked = false;

    // 아이템 인벤토리
    public ItemScript Inventory;

    // Zoom-in 고정 위치
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {
        // 클릭 시 줌인되는 고정 위치 설정
        zoomPosition = new Vector3(-6, 19, -20);
        zoomRotation = Quaternion.Euler(10, 258, 0);

        // Main Camera 불러오기
        cameraPosition = GameObject.Find("Main Camera").GetComponent<Transform>();
        playerViewScript = GameObject.Find("Main Camera").GetComponent<PlayerView>();

        // Inventory 불러오기
        Inventory = GameObject.Find("Inventory").GetComponent<ItemScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // 클릭 시 줌인
        cameraPosition.position = zoomPosition;
        cameraPosition.rotation = zoomRotation;

        Inventory.hasChair = true;
        chairClicked = true;
    }
}
