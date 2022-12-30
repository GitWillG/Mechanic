using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StudPoker
{
    public class CameraController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                CardGO hoveredCard = hit.collider.gameObject.GetComponent<CardGO>();
                Debug.Log(hit.transform.name);
                Debug.Log("hit");
                if (Input.GetMouseButtonUp(0))
                {
                    hoveredCard.isSelected = !hoveredCard.isSelected;
                }
            }
        }
        
    }
}
