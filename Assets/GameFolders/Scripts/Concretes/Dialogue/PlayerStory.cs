using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts.Concretes.Dialogue
{
    public class PlayerStory : MonoBehaviour
    {
        [SerializeField] private TMP_Text dialogueText;
        [SerializeField] private string[] dialogueSentences;
        [SerializeField] private GameObject continueButton;

        [SerializeField] private float writeSpeed;

        private int story;
        
        private void Start()
        {
            StartCoroutine(DialogueMethod());
        }

        private void Update()
        {
            if (dialogueText.text == dialogueSentences[story])
            {
                continueButton.SetActive(true);
            }
        }

        IEnumerator DialogueMethod()
        {
            foreach (char letter in dialogueSentences[story].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(writeSpeed);
            }
        }

        public void NextSentences()
        {
            continueButton.SetActive(false);
            
            if (story < dialogueSentences.Length -1)
            {
                story++;
                dialogueText.text = "";
                StartCoroutine(DialogueMethod());
            }
            else
            {
                //son cümle ise
            }
        }

        public void NextScene()
        {
            SceneManager.LoadScene("Tavern");
        }

    }
}
