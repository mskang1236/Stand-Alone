using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelevisionScript : MonoBehaviour
{

    // Main Camera 관련 Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // 텔레비전 인터렉션
    public bool televisionOn;
    public bool watchedCampaign;

    // Zoom-in 고정 위치
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {
        // 클릭 시 줌인되는 고정 위치 설정
        zoomPosition = new Vector3(12, 8, -20);
        zoomRotation = Quaternion.Euler(0, 180, 0);

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
        // 클릭 시 줌인
        cameraPosition.position = zoomPosition;
        cameraPosition.rotation = zoomRotation;

        // 텔레비전을 처음 조사할 경우
        if (televisionOn == false)
        {
            Debug.Log("텔레비전을 킨다");
            televisionOn = true;
        }

        // 텔레비전을 킬 경우
        else if (televisionOn == true && watchedCampaign == false)
        {
            Debug.Log("아동학대 신고 캠페인 광고 영상이다.");
            watchedCampaign = true;
        }

        // 캠페인 광고 영상 시청 후
        else if (televisionOn == true && watchedCampaign == true)
        {
            Debug.Log("공익광고가 방송되고 있다.");
        }
    }
}
