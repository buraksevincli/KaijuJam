using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts.Concretes.Dialogue
{
    public class GenTDialogue : MonoBehaviour
    {
        [SerializeField] private TMP_Text genText;
        [SerializeField] private TMP_Text usText;
        [SerializeField] private TMP_Text us2Text;
        [SerializeField] private string[] genDialogue;
        [SerializeField] private GameObject[] continueButton;
        [SerializeField] private GameObject sceneClosePanel;
        [SerializeField] private float writeSpeed;
        
        private string usDialogue;

        private void Start()
        {
            StartCoroutine(GenDialogue(GameManager.Instance.GenIndex));
        }

        private void Update()
        {
            if (genText.text == genDialogue[GameManager.Instance.GenIndex])
            {
                switch (GameManager.Instance.GenIndex)
                {
                    case 0:
                        continueButton[0].SetActive(true);
                        usText.text = "Hello Gan-T, nice to see you around. how you doin'?";
                        break;
                    case 1:
                        continueButton[0].SetActive(true);
                        usText.text = "Ihm, sorry. King Kong ate all my banana supply yesterday. What about an AquaMan?";
                        break;
                    case 2:
                        continueButton[0].SetActive(true);
                        usText.text = "Sure. Coming up.";
                        break;
                    case 3:
                        continueButton[0].SetActive(true);
                        usText.text = "Here you go. What do you want to talk about?";
                        break;
                    case 4:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Okaaay, what are you talking about? What god?";
                        us2Text.text = "What the hell are you talking about? Are you some kind of a missionary?";
                        break;
                    case 5:
                        continueButton[0].SetActive(true);
                        usText.text = "Yeah, sure. What is the name of this god by the way?";
                        break;
                    case 6:
                        continueButton[0].SetActive(true);
                        usText.text = "A god for us, then. I see. So what are the rules and my role in this?";
                        break;
                    case 7:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Okay. I can spread the words if you give me a guide book.";
                        us2Text.text = "I think you gone crazy, my friend. There is no way I spread words from an allaged god.";
                        break;
                    case 8:
                        continueButton[0].SetActive(true);
                        usText.text = "Okay, whatever. What is the name of this god by the way?";
                        break;
                    case 9:
                        continueButton[0].SetActive(true);
                        usText.text = "A god for us? Are there any rules or my role in this?";
                        break;
                    case 10:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "No need for a special way. I guess believing a god can be good for Kaijus.";
                        us2Text.text = "There is no way that I accept this. Took your missionary sh*t and sorry *ss out of here. There is no need for another power-hungry creature in our world.";
                        break;
                    default:
                        continueButton[0].SetActive(false);
                        continueButton[1].SetActive(false);
                        break;
                }
            }
        }

        public void Us1Button()
        {
            for (int i = 0; i < continueButton.Length; i++)
            {
                continueButton[i].SetActive(false);
            }

            switch (GameManager.Instance.GenIndex)
            {
                case 2:
                    StartCoroutine(GoToTheKitchen());
                    break;
                case 7:
                    SceneManager.LoadScene("GenGoodChoose");
                    GameManager.Instance.GenIndex = 0;
                    break;
                case 10:
                    SceneManager.LoadScene("GenGoodChoose");
                    GameManager.Instance.GenIndex = 0;
                    break;
                default:
                    GameManager.Instance.GenIndex++;
                    genText.text = "";
                    StartCoroutine(GenDialogue(GameManager.Instance.GenIndex));
                    break;
            }
        }

        public void Us2Button()
        {
            for (int i = 0; i < continueButton.Length; i++)
            {
                continueButton[i].SetActive(false);
            }

            switch (GameManager.Instance.GenIndex)
            {
                case 4:
                    GameManager.Instance.GenIndex = 8;
                    genText.text = "";
                    StartCoroutine(GenDialogue(GameManager.Instance.GenIndex));
                    break;
                case 7:
                    SceneManager.LoadScene("GenBadChoose");
                    GameManager.Instance.GenIndex = 0;
                    break;
                case 10:
                    SceneManager.LoadScene("GenBadChoose");
                    GameManager.Instance.GenIndex = 0;
                    break;
                default:
                    GameManager.Instance.GenIndex++;
                    genText.text = "";
                    StartCoroutine(GenDialogue(GameManager.Instance.GenIndex));
                    break;
            }
        }

        IEnumerator GenDialogue(int index)
        {
            foreach (char letter in genDialogue[GameManager.Instance.GenIndex].ToCharArray())
            {
                genText.text += letter;
                yield return new WaitForSeconds(writeSpeed);
            }
        }

        IEnumerator GoToTheKitchen()
        {
            sceneClosePanel.SetActive(true);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Kitchen");
        }
    }
}

