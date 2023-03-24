using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts.Concretes.Dialogue
{
    public class Dialogue : MonoBehaviour
    {
        [SerializeField] private TMP_Text dialogueText;
        [SerializeField] private string[] dialogueSentences;
        [SerializeField] private GameObject continueButton;
        [SerializeField] private GameObject[] chooseButton;

        [SerializeField] private float writeSpeed;

        private void Start()
        {
            StartCoroutine(DialogueMethod(GameManager.Instance.Index));
        }

        private void Update()
        {
            if (dialogueText.text == dialogueSentences[GameManager.Instance.Index])
            {
                switch (GameManager.Instance.Index)
                {
                    case 0: 
                        chooseButton[0].SetActive(true);
                        chooseButton[1].SetActive(true);
                        break;
                    case 1:
                        chooseButton[0].SetActive(false);
                        chooseButton[1].SetActive(false);
                        continueButton.SetActive(true);
                        break;
                    case 5:
                        chooseButton[0].SetActive(false);
                        chooseButton[1].SetActive(false);
                        break;
                    default:
                        continueButton.SetActive(true);
                        break;
                }
            }
        }

        IEnumerator DialogueMethod(int Index)
        {
            foreach (char letter in dialogueSentences[GameManager.Instance.Index].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(writeSpeed);
            }
        }

        public void NextSentences()
        {
            continueButton.SetActive(false);
            chooseButton[0].SetActive(false);
            chooseButton[1].SetActive(false);
            
            if (GameManager.Instance.Index < dialogueSentences.Length -1)
            {
                GameManager.Instance.Index++;
                dialogueText.text = "";
                StartCoroutine(DialogueMethod(GameManager.Instance.Index));
            }
            else
            {
                //son cümle ise
            }
        }

        public void PrepareFood()
        {
            GameManager.Instance.Index = 5;
            dialogueText.text = "";
            StartCoroutine(DialogueMethod(GameManager.Instance.Index));

            SceneManager.LoadScene("Kitchen");
        }
    }
}

