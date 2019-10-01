using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextController : MonoBehaviour
{
    public UnityEvent startEvent;
    private Text textLabel;

    public void UpdateText(IntData data)
    {
        textLabel.text = data.value.ToString();
    }
    void Start()
    {
        textLabel = GetComponent<Text>();
        startEvent.Invoke();
    }
}