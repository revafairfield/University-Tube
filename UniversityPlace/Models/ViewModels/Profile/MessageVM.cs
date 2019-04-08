﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityPlace.Models.Data;

namespace UniversityPlace.Models.ViewModels.Profile
{
    public class MessageVM
    {
        public MessageVM ()
        {

        }

        public MessageVM(MessageDTO row)
        {
            Id = row.Id;
            From = row.From;
            To = row.To;
            Message = row.Message;
            DateSent = row.DateSent;
            Read = row.Read;
            FromId = row.FromUsers.Id;
            FromUsername = row.FromUsers.Username;
            FromFirstName = row.FromUsers.FirstName;
            FromLastName = row.FromUsers.LastName;

        }

        public int Id { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public bool Read { get; set; }

        public int FromId { get; set; }
        public string FromUsername { get; set; }
        public string FromFirstName { get; set; }
        public string FromLastName { get; set; }
    }
}