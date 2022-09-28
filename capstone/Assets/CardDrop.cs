using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardDrop : MonoBehaviour, IPointerEnterHandler, IDropHandler, IPointerExitHandler
{
	private	Image			image;
	private	RectTransform	rect;

	private void Awake()
	{
		image	= GetComponent<Image>();
		rect	= GetComponent<RectTransform>();
	}

	public void OnPointerEnter(PointerEventData eventData)
	{

		image.color = Color.grey;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		
		image.color = Color.white;
	}

	public void OnDrop(PointerEventData eventData)
	{//내가 클릭을 뗀 곳
		Debug.Log("onDrop");
		if ( eventData.pointerDrag != null)
        {
				eventData.pointerDrag.transform.SetParent(transform);
				eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
		}

		Debug.Log(transform.name);

        if (this.transform.childCount > 1)
        {

			Transform changeCard = transform.GetChild(0);
			Transform precard = transform.GetChild(1).GetComponent<Card>().previousRect;


			changeCard.SetParent(precard);
			changeCard.localPosition = Vector3.zero;
		}



		/*
		if (eventData.pointerDrag.transform.parent.childCount > 1)
		{
			Transform changeCard = eventData.pointerDrag.transform.parent.GetChild(0);

			Debug.Log("child(0) : " + changeCard.name);
		}
		*/
	}
}

