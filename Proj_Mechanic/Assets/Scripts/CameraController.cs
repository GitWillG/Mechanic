using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Rahul - Remove all unused namespaces from all scripts.
//Also remove, all unused and zombie (commented out) code.
//Remove All debugs (Bad for performance in builds)

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
            //TODO: Rahul - Never use Camera.main in update, really bad for performance. 
            //Instead, cache the value in awake, and use the cached value throughout.
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                //TODO: Rahul - What about if you hit something else instead of a cardGO?
                //Use the CompareTag method to make sure this logic only runs when hitting a "Card"
                CardGO hoveredCard = hit.collider.gameObject.GetComponent<CardGO>();
                Debug.Log(hit.transform.name);
                Debug.Log("hit");
                //TODO: Rahul - minor thing, but add a "Select" method in the CardGO, that way if ever the selection logic needs to do more you do it in the right place.
                if (Input.GetMouseButtonUp(0))
                {
                    hoveredCard.isSelected = !hoveredCard.isSelected;
                }
            }
        }
        
    }
}
