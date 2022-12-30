using UnityEngine;


//Use the CompareTag method to make sure this logic only runs when hitting a "Card"

namespace StudPoker
{
    public class CameraController : MonoBehaviour
    {
        Camera mainCam;

        private void Awake()
        {
            mainCam = Camera.main;
        }
        void Update()
        {            
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {

                if (Input.GetMouseButtonUp(0) && hit.collider.gameObject.CompareTag("Card"))
                {
                    CardGO hoveredCard = hit.collider.gameObject.GetComponent<CardGO>();
                    //TODO: Rahul - minor thing, but add a "Select" method in the CardGO, that way if ever the selection logic needs to do more you do it in the right place.
                    hoveredCard.isSelected = !hoveredCard.isSelected;
                }
            }
        }
        
    }
}
