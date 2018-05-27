using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Globalization;

namespace SpeechRecognition
{
    public partial class SpeechRecognitionForm : Form
    {
        /// <summary>
        /// Указывается распознаваемый язык, в данном случае United States English
        /// </summary>
        static CultureInfo cultureInfo = new CultureInfo("en-us");
        /// <summary>
        /// Позволяет приложению прослушивать и распознавать произносимые слова или фразы
        /// </summary>
        static SpeechRecognitionEngine speechRecognition = new SpeechRecognitionEngine(cultureInfo);

        public SpeechRecognitionForm()
        {
            InitializeComponent();

            speechRecognition.SetInputToDefaultAudioDevice();
            speechRecognition.SpeechRecognized += SpeechRecognition_SpeechRecognized;

            Grammar g_HelloGoodbye = HelloGoodbyeGrammar();
            Grammar g_ColorChange = ChangeColorGrammar();
            Grammar g_Number = GetAmountGrammar();

            speechRecognition.LoadGrammarAsync(g_HelloGoodbye);
            speechRecognition.LoadGrammarAsync(g_ColorChange);
            speechRecognition.LoadGrammarAsync(g_Number);
        }

        /// <summary>
        /// Обработчик событий SpeechRecognized 
        /// </summary>
        private void SpeechRecognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string txt = e.Result.Text;
            float conf = e.Result.Confidence;

            if (conf < 0.65) return;

            this.Invoke(new MethodInvoker(() =>
            {
                if (txt.IndexOf("good morning") >= 0)
                {
                    lbWorkspace.Items.Add("Hello, Ksu! How are you?");
                }

                if (txt.IndexOf("goodbye") >= 0)
                {
                    lbWorkspace.Items.Add("GoodBye!");
                }
            }));

            this.Invoke(new MethodInvoker(() =>
            {
                if (txt.IndexOf("change") >= 0 && txt.IndexOf("green") >= 0)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pictureBox1.BackColor = Color.Green;
                    }));
                }

                if (txt.IndexOf("change") >= 0 && txt.IndexOf("blue") >= 0)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pictureBox1.BackColor = Color.Blue;
                    }));
                }

                if (txt.IndexOf("change") >= 0 && txt.IndexOf("red") >= 0)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pictureBox1.BackColor = Color.Red;
                    }));
                }

                if (txt.IndexOf("change") >= 0 && txt.IndexOf("yellow") >= 0)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pictureBox1.BackColor = Color.Yellow;
                    }));
                }
            }));

            this.Invoke(new MethodInvoker(() =>
            {
                if (txt.IndexOf("amount") >= 0 && txt.IndexOf("yes") >= 0)
                {
                    string[] words = txt.Split(' ');
                    int num1 = int.Parse(words[1]);
                    int num2 = int.Parse(words[3]);
                    int sum = num1 + num2;
                    lbWorkspace.Items.Add("The amount  = " + num1 + " + " + num2 + " = "+ sum);
                }
            }));
        }

        /// <summary>
        /// Метод, включающий распознавание речи
        /// </summary>
        private void btnEnable_Click(object sender, EventArgs e)
        {
            speechRecognition.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
        }

        /// <summary>
        /// Метод, выключающий распознавание речи
        /// </summary>
        private void btnDisable_Click(object sender, EventArgs e)
        {
            speechRecognition.RecognizeAsyncStop();
            btnDisable.Enabled = false;
        }

        /// <summary>
        /// Метод, настраивающий возможность распознавания команд для приветствия и прощания
        /// </summary>
        static Grammar HelloGoodbyeGrammar()
        {
            Choices ch_HelloGoodbye = new Choices();
            ch_HelloGoodbye.Add("good morning");
            ch_HelloGoodbye.Add("goodbye");
            GrammarBuilder gb_result =
              new GrammarBuilder(ch_HelloGoodbye);
            Grammar g_result = new Grammar(gb_result);
            return g_result;
        }

        /// <summary>
        /// Метод, настраивающий возможность распознавания цвета изменения pictureBox
        /// </summary>        
        static Grammar ChangeColorGrammar()
        {
            Choices ch_Colors = new Choices();
            ch_Colors.Add(new string[] { "green", "blue", "red", "yellow" });
            GrammarBuilder gb_result = new GrammarBuilder();
            gb_result.Append("change color");
            gb_result.Append(ch_Colors);
            Grammar g_result = new Grammar(gb_result);
            return g_result;
        }

        /// <summary>
        /// Метод, настраивающий возможность распознавание цифр для сложения
        /// </summary>
        static Grammar GetAmountGrammar()
        {
            Choices ch_Numbers = new Choices();
            ch_Numbers.Add("1");
            ch_Numbers.Add("2");
            ch_Numbers.Add("3");
            ch_Numbers.Add("4");

            GrammarBuilder gb_WhatIsXplusY = new GrammarBuilder();
            gb_WhatIsXplusY.Append("amount");
            gb_WhatIsXplusY.Append(ch_Numbers);
            gb_WhatIsXplusY.Append("yes");
            gb_WhatIsXplusY.Append(ch_Numbers);
            Grammar g_result = new Grammar(gb_WhatIsXplusY);

            return g_result;
        }
    }
}
