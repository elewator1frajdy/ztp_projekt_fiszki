﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ztp_projekt_fiszki
{
    class Easy : Strategia
    {
        public string question;
        public string correctAnswer;
        public string[] wrongAnswer = { "", "" };

        override public void play()
        {
            this.question = readQuestion(0);
            this.correctAnswer = readAnswer(0);
            this.wrongAnswer[0] = readAnswer(1);
            this.wrongAnswer[1] = readAnswer(2);
        }

        public string readQuestion(int index)
        {
            string q;
            // <--- zczytanie pytania z pliku
            return q;
        }

        public string readAnswer(int index)
        {
            string a;
            // <--- zczytanie odpowiedzi z pliku
            return a;
        }
    }
}
