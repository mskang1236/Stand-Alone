using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureScript : MonoBehaviour
{
    // Main Camera 관련 Class
    public Transform cameraPosition;
    public PlayerView playerViewScript;

    // Zoom-in 고정 위치
    private Vector3 zoomPosition;
    private Quaternion zoomRotation;

    // Start is called before the first frame update
    void Start()
    {
        // 고정 위치 설정
        zoomPosition = new Vector3(2, 6, 27);
        zoomRotation = Quaternion.Euler(-19, 0, 0);

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
    }
}
