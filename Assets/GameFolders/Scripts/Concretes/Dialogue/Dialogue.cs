using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameFolders.Scripts.Concretes.Dialogue
{
    public class Dialogue : MonoBehaviour
    {
        [SerializeField] private TMP_Text dialogueText;
        [SerializeField] private string[] dialogueSentences;
        [SerializeField] private GameObject continueButton;

        [SerializeField] private float writeSpeed;

        private int _dialogueIndex;

        private void Start()
        {
            StartCoroutine(DialogueMethod());
        }

        private void Update()
        {
            if (dialogueText.text == dialogueSentences[_dialogueIndex])
            {
                continueButton.SetActive(true);
            }
        }

        IEnumerator DialogueMethod()
        {
            foreach (char letter in dialogueSentences[_dialogueIndex].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(writeSpeed);
            }
        }

        public void NextSentences()
        {
            continueButton.SetActive(false);
            
            if (_dialogueIndex < dialogueSentences.Length -1)
            {
                _dialogueIndex++;
                dialogueText.text = "";
                StartCoroutine(DialogueMethod());
            }
            else
            {
                //son cümle ise
            }
        }
    }
}

