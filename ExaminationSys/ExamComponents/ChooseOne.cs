﻿using System;

namespace ExamComponents
{
    public class ChooseOne : Question
    {
        public ChooseOne(string _body, int _mark) 
            : base("Choose One", _body, _mark)
        { }
    }
}