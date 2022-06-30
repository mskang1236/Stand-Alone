using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelvesScript : MonoBehaviour
{

    // Main Camera 관련 Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    public bool shelvesClicked = false;
    private bool hasInvestigated = false;

    // 아이템 보유 현황
    public ItemScript Inventory;

    // Zoom-in 고정 위치
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {

        // Inventory 불러오기
        Inventory = GameObject.Find("Inventory").GetComponent<ItemScript>();

        // Main Camera 불러오기
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

        // 클릭 시 줌인되는 고정 위치 설정
        if (Inventory.hasChair == false) { zoomPosition = new Vector3(-22, 6, -40); }
        else { zoomPosition = new Vector3(-22, 20, -40); }
        zoomRotation = Quaternion.Euler(0, 270, 0);

        // 클릭 시 줌인
        cameraPosition.position = zoomPosition;
        cameraPosition.rotation = zoomRotation;

        shelvesClicked = true;

        // 의자가 없을 경우
        if (Inventory.hasChair == false)
        {
            Debug.Log("선반이 너무 높다.");
        }

        // 의자를 놓고 1차 조사
        else if (Inventory.hasChair == true && hasInvestigated == false)
        {
            Debug.Log("이웃 아이와 엄마의 이야기");
            hasInvestigated = true;
        }

        // 의자를 놓고 2차 조사
        else if (Inventory.hasChair == true && hasInvestigated == true && Inventory.hasDriver == false)
        {
            Debug.Log("선반에 드라이버가 있다. 쓸 일이 있을 것 같다.");
        }

        // 드라이버 획득 후
        else if (Inventory.hasDriver == true)
        {
            Debug.Log("더 이상 쓸만한 물건은 없어 보인다.");
        }
    }
}
