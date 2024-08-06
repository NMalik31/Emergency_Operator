using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CallManager : MonoBehaviour
{
    public Canvas callCanvas;
    public Canvas dialogueCanvas;
    public TextMeshProUGUI callNumberText;
    public TextMeshProUGUI dialogueText;
    public Button answerButton;
    public Button optionButton;

    private int currentCallIndex = 0;
    private float timeBetweenCalls = 10f;
    private string[] dialogues = {
        "Welcome to your new job as an Emergency Call Operator! We are glad to have you with us. I will be acting as your supervisor. In this job, you will get distress calls and you will have to respond to them accordingly. When they call you, listen carefully, as a small mistake can be very costly. With that being said, enjoy your first day!", 
        "Hey, my name is David, and I just heard a noise from my neighbour’s house. Something like a window breaking? I didn’t go and check. Can you send someone over?", 
        "Hello? There has been an accident on the highway! The car is in flames! Please send an ambulance quickly! We don’t know if there are survivors!", 
        "Granny fell down the stairs and she is not opening her eyes! Help, please!  ",
        "Is this the baker I am talking to? I would like to place an order for a loaf of ….. huh? Oh sorry! Wrong number",
        "Hey, I am outside the local jewellers’ and I think the place is being robbed. Can’t see inside but the door is locked and it seems very silent inside!",
        "Please, help….. help me. There is someone outside my bedroom door. Please dear god please. NO, STAY BACK NOOO",
        "Why are you breathing? Is it fun? Is it relaxing? Does it bring satisfaction? Didn’t think so "
    };

    void Start()
    {
        dialogueCanvas.gameObject.SetActive(false);
        StartCoroutine(StartCalls());
    }

    IEnumerator StartCalls()
    {
        while (currentCallIndex < dialogues.Length)
        {
            yield return new WaitForSeconds(timeBetweenCalls);
            ShowCall();
            yield return new WaitUntil(() => dialogueCanvas.gameObject.activeSelf);

        }
    }

    void ShowCall()
    {
        callNumberText.text = "Call " + (currentCallIndex + 1).ToString();
        callCanvas.gameObject.SetActive(true);
        optionButton.onClick.RemoveAllListeners();
        answerButton.onClick.AddListener(AnswerCall);
    }

    void AnswerCall()
    {
        callCanvas.gameObject.SetActive(false);
        ShowDialogue();
    }

    void ShowDialogue()
    {
        dialogueText.text = dialogues[currentCallIndex];
        dialogueCanvas.gameObject.SetActive(true);
        currentCallIndex++;
    }
}
