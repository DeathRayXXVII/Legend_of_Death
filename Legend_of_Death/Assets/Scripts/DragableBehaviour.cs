using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DragableBehaviour : MonoBehaviour
{

    private Camera cameraObj;

    public bool draggable;

    public Vector3 position, offset;

    public UnityEvent startDragEvent, endDragEvemt;
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main; //setting the camera to the main camera
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);//getting the position of the mouse input 
        draggable = true; //makes draggable true
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();//wait a couple seconds 
        
        while (draggable)
        {
            yield return new WaitForFixedUpdate(); //wait a couple seconds 
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset; //refining the mouse input position with the camera
            transform.position = position;
        }
    }

    public void OnMouseUp()
    {
        draggable = false; //makes draggale false
        endDragEvemt.Invoke();
    }
}
