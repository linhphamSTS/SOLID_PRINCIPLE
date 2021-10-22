using System;

namespace InterfaceSegregationPrinciple.BeforeISP
{
    internal class TeamLeader : IDevActivity
    {
        public string Name { get; set; }

        public void JoinMeeting()
        {
            Console.WriteLine("I join the meeting...!");
        }

        public void ReviewCode()
        {
            Console.WriteLine("OH MY GOD, STUPID CODE FROM MY TEAM....");
        }

        public void StudyRequirement()
        {
            Console.WriteLine("FUCK, It is a stupid document from BA.");
        }

        public void WriteCode()
        {
            Console.WriteLine("OH YEAH, I AM SUPPER CODER");
        }
    }
}