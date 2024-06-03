﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace KittyHorrorshowTranslations
{
    public class Anatomy : MonoBehaviour
    {
        public static Anatomy Instance;
        public void Awake()
        {
            Instance = this;
        }

        public AudioClip amen_TRANS;

        public Texture2D input_TRANS;
        public Texture2D title1_TRANS;
        public Texture2D title2_TRANS;
        public Texture2D title3_TRANS;
        public Texture2D title4_TRANS;

        public void AssetLoading()
        {
            switch (Plugin.Instance.gameLanguage)
            {
                case "French":
                    // Audio
                    amen_TRANS = Plugin.Instance.GetAudio("Achy Breaky Song.mp3");

                    // Images
                    input_TRANS = Plugin.Instance.GetTexture("Anatomy\\input_FR.png");
                    title1_TRANS = Plugin.Instance.GetTexture("Anatomy\\title1_FR.png");
                    title2_TRANS = Plugin.Instance.GetTexture("Anatomy\\title2_FR.png");
                    //title3_TRANS = Plugin.Instance.GetTexture("Anatomy\\title3_FR.png");
                    //title4_TRANS = Plugin.Instance.GetTexture("Anatomy\\title4_FR.png");

                    break;
                case "Dutch":
                    // Audio
                    amen_TRANS = Plugin.Instance.GetAudio("Achy Breaky Song.mp3");

                    // Images
                    input_TRANS = Plugin.Instance.GetTexture("Anatomy\\input_NL.png");
                    title1_TRANS = Plugin.Instance.GetTexture("Anatomy\\title1_NL.png");
                    title2_TRANS = Plugin.Instance.GetTexture("Anatomy\\title2_NL.png");
                    //title3_TRANS = Plugin.Instance.GetTexture("Anatomy\\title3_NL.png");
                    //title4_TRANS = Plugin.Instance.GetTexture("Anatomy\\title4_NL.png");

                    break;
                case "Japanese":
                    // Images
                    input_TRANS = Plugin.Instance.GetTexture("Anatomy\\input_JA.png");
                    title1_TRANS = Plugin.Instance.GetTexture("Anatomy\\title1_JA.png");
                    title2_TRANS = Plugin.Instance.GetTexture("Anatomy\\title2_JA.png");
                    //title3_TRANS = Plugin.Instance.GetTexture("Anatomy\\title3_JA.png");
                    //title4_TRANS = Plugin.Instance.GetTexture("Anatomy\\title4_JA.png");

                    break;
            }
        }

        public string TextReplacement(string str)
        {
            switch (str)
            {
                // House 1
                case "THERE IS A TAPE IN THE DINING ROOM":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE CASSETTE DANS LA SALLE À MANGER";
                            break;
                        case "Dutch":
                            str = "ER IS EEN CASSETTE IN DE EETKAMER";
                            break;
                        case "Japanese":
                            if (Plugin.Instance.currentLevelIndex > 1)
                            {
                                str = "食堂にカセットがいる";// いる (animate)
                            }
                            else
                            {
                                str = "食堂にカセットがある";// ある (inanimate)
                            }
                            break;
                    }
                    break;
                case "THERE IS A TAPE IN THE DOWNSTAIRS BATHROOM":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE CASSETTE DANS LA SALLE DE BAINS EN BAS";
                            break;
                        case "Dutch":
                            str = "ER IS EEN CASSETTE IN DE BENEDEN BADKAMER";
                            break;
                        case "Japanese":
                            if (Plugin.Instance.currentLevelIndex > 1)
                            {
                                str = "階下の風呂場にカセットがいる";
                            }
                            else
                            {
                                str = "階下の風呂場にカセットがある";
                            }
                            break;
                    }
                    break;
                case "THERE IS A TAPE IN THE GARAGE":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE CASSETTE DANS LE GARAGE";
                            break;
                        case "Dutch":
                            str = "ER IS EEN CASSETTE IN DE GARAGE";
                            break;
                        case "Japanese":
                            if (Plugin.Instance.currentLevelIndex > 1)
                            {
                                str = "車庫にカセットがいる";
                            }
                            else
                            {
                                str = "車庫にカセットがある";
                            }
                            break;
                    }
                    break;
                case "THERE IS A TAPE IN THE LIVING ROOM":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE CASSETTE DANS LE SALON";
                            break;
                        case "Dutch":
                            str = "ER IS EEN CASSETTE IN DE WOONKAMER";
                            break;
                        case "Japanese":
                            if (Plugin.Instance.currentLevelIndex > 1)
                            {
                                str = "居間にカセットがいる";
                            }
                            else
                            {
                                str = "居間にカセットがある";
                            }
                            break;
                    }
                    break;
                case "THERE IS A TAPE ON THE STAIRS":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE CASSETTE SUR LES ESCALIERS";
                            break;
                        case "Dutch":
                            str = "ER IS EEN CASSETTE OP DE TRAP";
                            break;
                        case "Japanese":
                            if (Plugin.Instance.currentLevelIndex > 1)
                            {
                                str = "階段にカセットがいる";
                            }
                            else
                            {
                                str = "階段にカセットがある";
                            }
                            break;
                    }
                    break;
                case "THERE IS A TAPE IN A BEDROOM":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE CASSETTE DANS UNE CHAMBRE";
                            break;
                        case "Dutch":
                            str = "ER IS EEN CASSETTE IN EEN SLAAPKAMER";
                            break;
                        case "Japanese":
                            if (Plugin.Instance.currentLevelIndex > 1)
                            {
                                str = "ある寝室にカセットがいる";
                            }
                            else
                            {
                                str = "ある寝室にカセットがある";
                            }
                            break;
                    }
                    break;
                case "THERE IS A TAPE IN THE BASEMENT":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE CASSETTE DANS LE SOUS-SOL";
                            break;
                        case "Dutch":
                            str = "ER IS EEN CASSETTE IN DE KELDER";
                            break;
                        case "Japanese":
                            if (Plugin.Instance.currentLevelIndex > 1)
                            {
                                str = "地下室にカセットがいる";
                            }
                            else
                            {
                                str = "地下室にカセットがある";
                            }
                            break;
                    }
                    break;
                case "THERE IS A TAPE IN THE MASTER BEDROOM":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE CASSETTE DANS LA CHAMBRE PRINCIPALE";
                            break;
                        case "Dutch":
                            str = "ER IS EEN CASSETTE IN DE HOOFDSLAAPKAMER";
                            break;
                        case "Japanese":
                            if (Plugin.Instance.currentLevelIndex > 1)
                            {
                                str = "主寝室にカセットがいる";
                            }
                            else
                            {
                                str = "主寝室にカセットがある";
                            }
                            break;
                    }
                    break;

                // House 2+
                case "THERRRRRRRRRRRR       RE IS A TAPE IN THE DINING ROOM":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "ILLLLLLLLLLLLLL       Ÿ A UNE CASSETTE DANS LA SALLE À MANGER";
                            break;
                        case "Dutch":
                            str = "ERRRRRRRRRRRRRR       IS EEN CASSETTE IN DE EETKAMER";
                            break;
                        case "Japanese":
                            str = "食堂にiiiiiiiiiiiiii       カセットがいる";
                            break;
                    }
                    break;
                case "THERE IS A TA   A A  AAAA  A         DOOrRS ARE UnNLOCKED":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE CA   A A  AAAA  A         POrTES SONT DéVERROUILLÉES";
                            break;
                        case "Dutch":
                            str = "ER IS EEN CA   A A  AAAA  A         DEuREN ZIJN ONTGRENDELD";
                            break;
                        case "Japanese":
                            str = "カセットがいi   i i  iiii  i         すべてnoドアはロックされていない";
                            break;
                    }
                    break;
                case "THERE IS A TTHERE IS A TTHERE IS A TTHERE IS A TTHERE IS A TTHERE IS A TTHERE IS A TTHERE IS A T":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "IL Y A UNE IIL Y A UNE IIL Y A UNE IIL Y A UNE IIL Y A UNE IIL Y A UNE IIL Y A UNE IIL Y A UNE C";
                            break;
                        case "Dutch":
                            str = "ER IS EEN EER IS EEN EER IS EEN EER IS EEN EER IS EEN EER IS EEN EER IS EEN EER IS EEN C";
                            break;
                        case "Japanese":
                            str = "トがいる gがいる gがいる gがいる gがいる gがいる gがいる gがいる";
                            break;
                    }
                    break;
                case "THHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "ILLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
                            break;
                        case "Dutch":
                            str = "ERRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR";
                            break;
                        case "Japanese":
                            str = "がいrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr";
                            break;
                    }
                    break;
                case "                                                                          HHHHHHHHHHHHHHHHHHHHHHHURTS":
                    switch (Plugin.Instance.gameLanguage)
                    {
                        case "French":
                            str = "                                                                          FFFFFFFFFFFFFFFFFFFFAIT MAL";
                            break;
                        case "Dutch":
                            str = "                                                                          DDDDDDDDDDDDDDDDDDDOET PIJN";
                            break;
                        case "Japanese":
                            str = "                                                                          iiiiiiiiiiiiiiiiiiiiii痛い";
                            break;
                    }
                    break;
            }
            return str;
        }

        public UnityEngine.Object AudioReplacement(UnityEngine.Object audioClip)
        {
            switch (audioClip.name)
            {
                case "amen":
                    audioClip = amen_TRANS;
                    break;
            }
            return audioClip;
        }

        public UnityEngine.Sprite TextureReplacement(SpriteRenderer spriteRenderer)
        {
            switch (spriteRenderer.gameObject.name)
            {
                case "input":
                    spriteRenderer.sprite = Sprite.Create(input_TRANS, new Rect(0.0f, 0.0f, 800, 600), new Vector2(0.5f, 0.5f), 100.0f);
                    break;
                case "title1":
                    spriteRenderer.sprite = Sprite.Create(title1_TRANS, new Rect(0.0f, 0.0f, 800, 600), new Vector2(0.5f, 0.5f), 100.0f);
                    break;
                case "title2":
                    spriteRenderer.sprite = Sprite.Create(title2_TRANS, new Rect(0.0f, 0.0f, 800, 600), new Vector2(0.5f, 0.5f), 100.0f);
                    break;
                case "title3":
                    spriteRenderer.sprite = Sprite.Create(title3_TRANS, new Rect(0.0f, 0.0f, 800, 600), new Vector2(0.5f, 0.5f), 100.0f);
                    break;
                case "title4":
                    spriteRenderer.sprite = Sprite.Create(title4_TRANS, new Rect(0.0f, 0.0f, 800, 600), new Vector2(0.5f, 0.5f), 100.0f);
                    break;
            }
            return spriteRenderer.sprite;
        }
    }
}