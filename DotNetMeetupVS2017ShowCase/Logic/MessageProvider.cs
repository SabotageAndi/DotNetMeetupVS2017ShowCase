using DotNetMeetupVS2017ShowCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetMeetupVS2017ShowCase.Logic
{
    public enum MessageTyp
    {
        IndexPage,
        ContactPage,
        AboutPage
    }

    public class MessageProvider
    {

        public MessageDto GetMessage(MessageTyp messageTyp)
        {
            switch (messageTyp)
            {
                case MessageTyp.AboutPage:
                    {
                        return new MessageDto() { Message = "Your application description page." };
                    }
                case MessageTyp.ContactPage:
                    {
                        var messageDto = new MessageDto();
                        messageDto.Message = "Your contact page."; //TODO Object Initializer
                        return messageDto;
                    }
                case MessageTyp.IndexPage:
                    {
                        var messageDto = new MessageDto();
                        messageDto.Message = "Welcome!";
                        return messageDto;
                    }
            }

            var x = GetMessage(messageTyp);


            return new MessageDto() { Message = "Lorem ipsum dolor sit amet." };
        }
    }
}