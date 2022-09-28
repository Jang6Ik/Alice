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
		previousRect = transform.parent.transform;   //�ű�� ���� �θ��� ��ġ


		previousParent = transform.parent;

		transform.SetParent(canvas);		 //�θ� canvas�� ����
		transform.SetAsLastSibling();	

		canvasGroup.alpha = 0.6f;
		canvasGroup.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		rect.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{//eventData�� ���� Ŭ���Ѱ�
		if ( transform.parent == canvas )
        {
			transform.SetParent(previousParent);
				rect.position = previousParent.GetComponent<RectTransform>().position;
		}

		canvasGroup.alpha = 1.0f;
		canvasGroup.blocksRaycasts = true;
	}
}

