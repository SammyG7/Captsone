using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using Unity.Services.Vivox;



public class SendMessageButton : MonoBehaviour
{
    [SerializeField] InputField chatBox;
    
    [SerializeField] VivoxTextManager textMan;

    //[SerializeField] VivoxVoiceManager voiceMan;
/*     public int maxMessages = 25;

    public GameObject chatPanel, textObject;
    public InputField chatBox;

    [SerializeField]
    List<Message> messageList = new List<Message>(); */
	public void OnButtonPress()
	{
        Debug.Log("Button");
        if(chatBox.text != ""){
            Debug.Log("Text entered");
            //VivoxService.Instance.Initialize();
            //voiceMan.Login();
            textMan.SendMessageToChat(chatBox.text);
            chatBox.text = "";
        }
		//VivoxVoiceManager.SendTextMessage();
	}
/*         public void SendMessageToChat(string text){
        if(messageList.Count >= maxMessages){
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }

        Message newMessage = new Message();
        newMessage.text = text;

        GameObject newText = Instantiate(textObject, chatPanel.transform);

        newMessage.textObject = newText.GetComponent<Text>();
        newMessage.textObject.text = newMessage.text;

        messageList.Add(newMessage);
    } */
    /*
    [System.Serializable]
    public class Message{
        public string text;
        public Text textObject;
    } */
}
