using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace GameFolders.Scripts.Concretes.Dialogue
{
    public class QuazillDialogue : MonoBehaviour
    {
        [SerializeField] private TMP_Text godText;
        [SerializeField] private TMP_Text usText;
        [SerializeField] private TMP_Text us2Text;
        [SerializeField] private string[] godzillaDialogue;
        [SerializeField] private GameObject[] continueButton;
        [SerializeField] private GameObject sceneClosePanel;

        [SerializeField] private float writeSpeed;
        
        private string usDialogue;

        private void Start()
        {
            StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
        }

        private void Update()
        {
            if (godText.text == godzillaDialogue[GameManager.Instance.GodIndex])
            {
                switch (GameManager.Instance.GodIndex)
                {
                    case 0:
                        continueButton[0].SetActive(true);
                        usText.text =
                            "Hello Qua, nice to see you around. Is everything okay with the ganster life?";
                        break;
                    case 1:
                        continueButton[0].SetActive(true);
                        usText.text = "Okay, what you wanna eat? The regular?";
                        break;
                    case 2:
                        continueButton[0].SetActive(true);
                        usText.text = "One ---------- with a glass of blood. Coming up.";
                        break;
                    case 3:
                        continueButton[0].SetActive(true);
                        usText.text = "So, whats up with the new ones you mentioned?";
                        break;
                    case 4:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Times have changed, my old friend. They don’t know our ways like we did. You should be more patient.";
                        us2Text.text = "Yeah, new generation is full of dead ducks. Someone must knock some sense in them.";
                        break;
                    case 5:
                        continueButton[0].SetActive(true);
                        usText.text = "Of course I am right, I spent half of my life in this mess. Youngsters are always the most challenging ones.";
                        break;
                    case 6:
                        continueButton[0].SetActive(true);
                        usText.text = "Really, you gotta be kidding me. Nukes, for real?";
                        break;
                    case 7:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Totally. But you must remember we also struggle to keep up with our fathers and their ways in times.";
                        us2Text.text = "Yeah you're right. In our times, our fires and lasers remains in the family.";
                        break;
                    case 8:
                        continueButton[0].SetActive(true);
                        usText.text =
                            "Yeah of course my friend. He was really a gangsta king at heart. I still remember the day he tought me how to breath fire.";
                        break;
                    case 9:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text =
                            "Simple times with our fathers and brothers. Even the times changed, you know our way of look after each other. Don't be too harsh on them.";
                        us2Text.text = "But the time has changed and now you are responsible for those kids. You must hold them accountable.";
                        break;
                    case 10:
                        continueButton[0].SetActive(true);
                        usText.text = "You are not that bad yourself either. You can teach them be better in their nature.";
                        break;
                    case 11:
                        continueButton[0].SetActive(true);
                        usText.text = "What do you mean?";
                        break;
                    case 12:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Come on brother, just let them have their new way of business with traditions. They are youngsters, and this is still killing bunch of people with fire breath or nukes.";
                        us2Text.text = "Holy sh*t brother. You must go and start to focus on them. You must turn them back to their own nature without those sh*tty contracts.";
                        break;
                    case 13:
                        continueButton[0].SetActive(true);
                        usText.text = "You are not that bad yourself either. I serve my time and took a step down because of those things.";
                        break;
                    case 14:
                        continueButton[0].SetActive(true);
                        usText.text = "What do you mean?";
                        break;
                    case 15:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Come on now, let them have their new way of business with traditions. Nukes are still killing bunch of people and ads will never gonna make out anyways.";
                        us2Text.text = "Holy sh*t brother. They must gone crazy. You must turn them back to their own nature.";
                        break;
                    case 16:
                        continueButton[0].SetActive(true);
                        usText.text = "Yeah of course my friend. He was really a gangsta king at heart. I still remember the day he tought me how to breath fire.";
                        break;
                    case 17:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Yeah, in our times. Even the times changed, you know our way of look after each other in the family. Be understanding.";
                        us2Text.text = "It is the way, brother. There must be no snitches. You must hold them accountable.";
                        break;
                    case 18:
                        continueButton[0].SetActive(true);
                        usText.text = "Come on, you can also teach them be better in their nature. Look after them to be better monsters.";
                        break;
                    case 19:
                        continueButton[0].SetActive(true);
                        usText.text = "What the hell are you talking about?";
                        break;
                    case 20:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text =
                            "Ohh those kids. They are funny. Come on now, let them have their new way of business with traditions. It can be progressive.";
                        us2Text.text = "Wow, that's a bit far-stretched. They must be stopped before bring our name into mud.";
                        break;
                    case 21:
                        continueButton[0].SetActive(true);
                        usText.text = "You are not that bad yourself either. I serve my time and took a step down because of those things.";
                        break;
                    case 22:
                        continueButton[0].SetActive(true);
                        usText.text = "What do you mean?"; 
                        break;
                    case 23:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text =
                            "I know I said it may times, but times really have been changed. Our people as famous ones, it is fun. We should let them be. It can be good for image.";
                        us2Text.text = "Okay, that's the line you must step in. They must be stopped before bring our name into mud or our secrets in danger.";
                        break;
                    case 24:
                        continueButton[0].SetActive(true);
                        usText.text = "Of course I am right, I spent half of my life in this mess. Youngsters are always the most stupid ones without use a firm hand.";
                        break;
                    case 25:
                        continueButton[0].SetActive(true);
                        usText.text = "Really, you gotta be kidding me. Nukes, for real?";
                        break;
                    case 26:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text =
                            "You know our way. Just tell them to step down this sh*t and tought them better way like our fathers did to us.";
                        us2Text.text = "You can't have bunch of kids going and reveal our secrets to governments. Imagine what your father would do.";
                        break;
                    case 27:
                        continueButton[0].SetActive(true);
                        usText.text = "Yeah of course my friend. He was really a gangsta king at heart. I still remember the day he tought me how to breath fire.";
                        break;
                    case 28:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Yeah, in our times, but I am sure they also see you as a father. Be understanding to them.";
                        us2Text.text = "It was the way, brother. They show us to be better with respect and fear.";
                        break;
                    case 29:
                        continueButton[0].SetActive(true);
                        usText.text = "Come on, you can also teach them be better in their nature. Look after them to be better monsters.";
                        break;
                    case 30:
                        continueButton[0].SetActive(true);
                        usText.text = "What the hell are you talking about?";
                        break;
                    case 31:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Is it really so bad? We should let them be. It can be good for image.";
                        us2Text.text = "Okay, that's the time for those b*stards to learn a lesson. They must be stopped before bring our secrets in danger.";
                        break;
                    case 32:
                        continueButton[0].SetActive(true);
                        usText.text = "You are not that bad yourself either. Just remember our fathers, respect and fear.";
                        break;
                    case 33:
                        continueButton[0].SetActive(true);
                        usText.text = "What do you mean?";
                        break;
                    case 34:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "You should let them be wrong in their own way to learn hard truths. We are monsters have nobody but our kinds.";
                        us2Text.text = "Okay, that's the time for those b*stards to learn fear again. They must learn the rules from the start with harder lessons.";
                        break;
                    case 35:
                        continueButton[0].SetActive(true);
                        usText.text = "Yeah of course my friend. He was really a gangsta king at heart. I still remember the day he tought me how to breath fire.";
                        break;
                    case 36:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "Yeah, in our times, but I am sure you can go softer than your father. You should keep up with the new times";
                        us2Text.text = "It was the way, brother. He'd make sure nobody endanger our organization.";
                        break;
                    case 37:
                        continueButton[0].SetActive(true);
                        usText.text = "Come on, you can also teach them be better in their nature. Look after them to be a good boss.";
                        break;
                    case 38:
                        continueButton[0].SetActive(true);
                        usText.text = "What the hell are you talking about?";
                        break;
                    case 39:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "They must learn their wrongs in their speed. Just make sure they have a price to pay at the end brother.";
                        us2Text.text = "Wow, that's a bit far-stretched. They must be stopped before bring our traditions in a shame.";
                        break;
                    case 40:
                        continueButton[0].SetActive(true);
                        usText.text = "You are not that bad yourself either. You can keep a bunch of losers in a line.";
                        break;
                    case 41:
                        continueButton[0].SetActive(true);
                        usText.text = "What do you mean?";
                        break;
                    case 42:
                        continueButton[0].SetActive(true);
                        continueButton[1].SetActive(true);
                        usText.text = "You should let them be wrong in their own way to learn hard truths. We are monsters have nobody but our kinds.";
                        us2Text.text = "I see. It is the time for those b*stards learn some fear. You should make them suffer for their stupidity.";
                        break;
                    default:
                        continueButton[0].SetActive(false);
                        continueButton[1].SetActive(false);
                        break;
                }
            }
        }

        IEnumerator GodzillaDialogue(int Index)
        {
            foreach (char letter in godzillaDialogue[GameManager.Instance.GodIndex].ToCharArray())
            {
                godText.text += letter;
                yield return new WaitForSeconds(writeSpeed);
            }
        }

        public void Us1Button()
        {
            for (int i = 0; i < continueButton.Length; i++)
            {
                continueButton[i].SetActive(false);
            }

            switch (GameManager.Instance.GodIndex)
            {
                case 2:
                    StartCoroutine(GoToTheKitchen());
                    break;
                case 12:
                    Debug.Log("Mutlu Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 15:
                    Debug.Log("Mutlu Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 20:
                    Debug.Log("Mutlu Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 23:
                    Debug.Log("Mutlu Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 31:
                    Debug.Log("Mutlu Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 34:
                    Debug.Log("Mutlu Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 39:
                    Debug.Log("Mutlu Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 42:
                    Debug.Log("Mutlu Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                default:
                    GameManager.Instance.GodIndex++;
                    godText.text = "";
                    StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
                    break;
            }
        }

        public void Us2Button()
        {
            for (int i = 0; i < continueButton.Length; i++)
            {
                continueButton[i].SetActive(false);
            }

            switch (GameManager.Instance.GodIndex)
            {
                case 4:
                    GameManager.Instance.GodIndex = 24;
                    godText.text = "";
                    StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
                    break;
                case 7:
                    GameManager.Instance.GodIndex = 16;
                    godText.text = "";
                    StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
                    break;
                case 9:
                    GameManager.Instance.GodIndex = 13;
                    godText.text = "";
                    StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
                    break;
                case 12:
                    Debug.Log("Mutsuz Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 15:
                    Debug.Log("Mutsuz Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 17:
                    GameManager.Instance.GodIndex = 21;
                    godText.text = "";
                    StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
                    break;
                case 20:
                    Debug.Log("Mutsuz Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 23:
                    Debug.Log("Mutsuz Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 26:
                    GameManager.Instance.GodIndex = 35;
                    godText.text = "";
                    StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
                    break;
                case 28:
                    GameManager.Instance.GodIndex = 32;
                    godText.text = "";
                    StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
                    break;
                case 31:
                    Debug.Log("Mutsuz Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 34:
                    Debug.Log("Mutsuz Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 36:
                    GameManager.Instance.GodIndex = 40;
                    godText.text = "";
                    StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
                    break;
                case 39:
                    Debug.Log("Mutsuz Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                case 42:
                    Debug.Log("Mutsuz Son");
                    GameManager.Instance.GodIndex = 0;
                    break;
                default:
                    GameManager.Instance.GodIndex++;
                    godText.text = "";
                    StartCoroutine(GodzillaDialogue(GameManager.Instance.GodIndex));
                    break;
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

