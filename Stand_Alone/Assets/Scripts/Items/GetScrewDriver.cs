using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScrewDriver : MonoBehaviour
{

    private GameObject screwDriver;
    public bool getDriver = false;

    public ShelvesScript KitchenShelvesScript;

    // Start is called before the first frame update
    void Start()
    {
        screwDriver = this.gameObject;
        KitchenShelvesScript = GameObject.Find("Kitchen Shelve").GetComponent<ShelvesScript>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        if (KitchenShelvesScript.shelvesClicked == true)
        {
            Debug.Log("µå¶óÀÌ¹ö¸¦ Ã¬°å´Ù.");
            Destroy(screwDriver);
            getDriver = true;
        }
    }
}
