using UnityEngine;
using UnityEngine.EventSystems;

public class Card :  Cardinfo,IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private	Transform		canvas;				
	private	Transform		previousParent;		
	private	RectTransform	rect;				
	private	CanvasGroup		canvasGroup;

	public Transform previousRect;

	[SerializeField]
    public new shape shape;
	[SerializeField]
	public new number number;
	private void Awake()
	{


		canvas		= FindObjectOfType<Canvas>().transform;
		rect		= GetComponent<RectTransform>();
		canvasGroup	= GetComponent<CanvasGroup>();
		previousRect = transform.parent;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		previousRect = transform.parent.transform;   //옮기기 전의 부모의 위치


		previousParent = transform.parent;

		transform.SetParent(canvas);		 //부모 canvas로 변경
		transform.SetAsLastSibling();	

		canvasGroup.alpha = 0.6f;
		canvasGroup.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		rect.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{//eventData는 내가 클릭한거
		if ( transform.parent == canvas )
        {
			transform.SetParent(previousParent);
				rect.position = previousParent.GetComponent<RectTransform>().position;
		}

		canvasGroup.alpha = 1.0f;
		canvasGroup.blocksRaycasts = true;
	}
}

