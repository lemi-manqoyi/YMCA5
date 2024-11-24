﻿using System;

namespace YmcaApiClient
{
    public class Event
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime Date { get; set; }
    }
}