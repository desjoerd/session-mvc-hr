﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeSjoerd.FeedbackApp.Core.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required, Range(1, 5)]
        public int? Rating { get; set; }
    }
}
